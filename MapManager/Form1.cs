using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapManager
{
    public partial class Form1 : Form
    {

        Bitmap renderedMap = null;
        Bitmap overlayImage = null;
        Bitmap combinedImage = null;
        Point overlayLocation = new Point();
        bool isEditingImage = false;
        bool isModifyingLayer = false;
        int editinglayerIndex = -1;
        static int overlayScale = 100;
        Bitmap originalOverlayImage = null;

        BindingList<Layer> layers = new BindingList<Layer>();

        decimal scalex;
        decimal scaley;


        public Form1()
        {
            InitializeComponent();
            layers.Add(new Layer() { FileName = "", Current = new Bitmap(mapPictureBox.Image), Location = new Point(0, 0) });

            renderedMap = RenderLayers();
            mapPictureBox.Image = renderedMap;

            mapPictureBox_Resize(this, new EventArgs());

            //Bind the ComboBox to our Layers Structure
            BindingSource layersBindingSource = new BindingSource();
            layersBindingSource.DataSource = layers;
            layerSelectionComboBox.DataSource = layersBindingSource.DataSource;
            layerSelectionComboBox.DisplayMember = "Name";
            layerSelectionComboBox.ValueMember = "Current";

            //Bind the ComboBox to our Assets BindingSource
            BindingSource assetsBindingSource = new BindingSource();
            assetsBindingSource.DataSource = AssetFactory.Construct(@"C:\Users\locob\Documents\GitHub\CSC352_Public\MapManager\Assets");
            assetsComboBox.DataSource = assetsBindingSource.DataSource;
            assetsComboBox.DisplayMember = "Name";
            assetsComboBox.ValueMember = "FilePath";

            //Bind the Mouse Wheel Events
            MouseWheel += Form1_MouseWheel;
        }

        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (isEditingImage)
            {
                if (originalOverlayImage == null)
                {
                    originalOverlayImage = new Bitmap(overlayImage);
                }

                debugStatus.Text = $"Edit Mode: ON Size: {e.Delta} Scale: {overlayScale}";

                int increaseScaleBy = 1;

                if(Control.ModifierKeys == Keys.Shift)
                {
                    increaseScaleBy = 10;
                }

                if (e.Delta > 1)
                {
                    // If Positive Grow Image
                    overlayScale = overlayScale + increaseScaleBy;
                }
                else
                {
                    // Negative Shrink
                    if(overlayScale - increaseScaleBy > 1)
                    {
                        overlayScale = overlayScale - increaseScaleBy;
                    }
                }

                double scale = overlayScale * .01;

                Size scaledSize = Renderer.Scale(originalOverlayImage.Size, scale);

                scaledImageLabel.Text = scaledSize.ToString();

                Bitmap scaledBitmap = new Bitmap(originalOverlayImage, scaledSize); 
                // this works for increasing but once gets back to zero it breaks

                overlayImage.Dispose();
                overlayImage = null;
                overlayImage = scaledBitmap;

            }
            else
            {
                debugStatus.Text = $"Edit Mode: OFF Size: {e.Delta}";
            }
        }

        private Bitmap RenderLayers()
        {
            return Renderer.RenderLayers(layers, mapPictureBox.Image.Width, mapPictureBox.Image.Height);
        }

        private void assetPictureBox_Click(object sender, EventArgs e)
        {
            overlayImage = new Bitmap(assetPictureBox.Image);
            mapPictureBox.Cursor = Cursors.Cross;
            isEditingImage = true;
        }

        private void ShowCombinedImage()
        {
            if (renderedMap == null && overlayImage == null)
            {
                return;
            }

            mapPictureBox.Image = renderedMap;

            if (combinedImage != null)
            {
                combinedImage.Dispose();
                combinedImage = null;
            }

            combinedImage = new Bitmap(renderedMap);

            using (Graphics combiner = Graphics.FromImage(combinedImage))
            {
                combiner.DrawImage(overlayImage, overlayLocation);
            }

            mapPictureBox.Image = combinedImage;
        }


        private void mapPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (overlayImage == null)
            {
                return;
            }

            overlayLocation = new Point(
                (int)(e.X * scalex) - overlayImage.Width / 2,
                (int)(e.Y * scaley) - overlayImage.Height / 2);

            if (isModifyingLayer)
            {
                layers[editinglayerIndex].Location = overlayLocation;
                layers[editinglayerIndex].Current.Dispose();
                layers[editinglayerIndex].Current = new Bitmap(overlayImage);
                layers[editinglayerIndex].ShouldRender = true;
                Image previousImage = mapPictureBox.Image;
                mapPictureBox.Image = RenderLayers();
                previousImage.Dispose();
                layers[editinglayerIndex].ShouldRender = false;
            }
            else
            {
                ShowCombinedImage();
            }

            mousePosActual.Text = $"MousePosActual - X: {e.X}, Y:{e.Y}";
            mousePosScaled.Text = $"MousePosScaled - X: {overlayLocation.X}, Y:{overlayLocation.Y}";
        }

        private void mapPictureBox_Resize(object sender, EventArgs e)
        {
            scalex = Decimal.Divide(renderedMap.Width, mapPictureBox.Width);
            scaley = Decimal.Divide(renderedMap.Height, mapPictureBox.Height);
        }

        private void mapPictureBox_Click(object sender, EventArgs e)
        {
            if(overlayImage == null)
            {
                return;
            }

            if (isModifyingLayer)
            {
                layers[editinglayerIndex].ShouldRender = true;
                editinglayerIndex = -1;
                isModifyingLayer = false;
            }
            else
            {
                layers.Add(new Layer() { Current = new Bitmap(overlayImage), FileName = string.Empty, Location = overlayLocation });
            }
            
            mapPictureBox.Cursor = Cursors.Default;
            overlayImage.Dispose();
            overlayImage = null;

            renderedMap = RenderLayers();
            mapPictureBox.Image = renderedMap;
            overlayScale = 100;

            originalOverlayImage?.Dispose();
            originalOverlayImage = null;

            isEditingImage = false;
        }

        private void layerSelectionComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (layerSelectionComboBox.SelectedValue is Bitmap)
            {
                layerPreviewPictureBox.Image = layerSelectionComboBox.SelectedValue as Bitmap;
            }
            else if (layerSelectionComboBox.SelectedValue is Layer)
            {
                layerPreviewPictureBox.Image = (layerSelectionComboBox.SelectedValue as Layer).Current;
            }
            else
            {
                //Do Nothing
            }
        }

        private void layerEditButton_Click(object sender, EventArgs e)
        {
            overlayImage = new Bitmap(layerSelectionComboBox.SelectedValue as Bitmap);
            editinglayerIndex = layerSelectionComboBox.SelectedIndex;
            layers[editinglayerIndex].ShouldRender = false;
            renderedMap = RenderLayers();
            mapPictureBox.Cursor = Cursors.Cross;
            isEditingImage = true;
            isModifyingLayer = true;
        }

        private void assetsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Knowing where the asset file is
            string assetFilePath;

            if (assetsComboBox.SelectedValue is string)
            {
                assetFilePath = assetsComboBox.SelectedValue as string;
            }
            else if (assetsComboBox.SelectedValue is Asset)
            {
                assetFilePath = (assetsComboBox.SelectedValue as Asset).FilePath;
            }
            else
            {
                throw new InvalidOperationException();
            }

            //Load up the asset file as a bitmap
            Bitmap assetPicture = new Bitmap(assetFilePath);

            assetPictureBox.Image = assetPicture;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Bitmap(*.bmp)|*.bmp";
                DialogResult result = sfd.ShowDialog();
                if(result == DialogResult.OK)
                {
                    mapPictureBox.Image.Save(sfd.FileName);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JPEG (*.jpg)|*.jpg|Bitmap (*.bmp)|*.bmp";
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    mapPictureBox.Image = new Bitmap(ofd.FileName);
                    layerSelectionComboBox.DataSource = null;
                    layers.Clear();
                    layers.Add(new Layer() { Name = "Base", FileName = ofd.FileName, Current = new Bitmap(mapPictureBox.Image), Location = new Point(0, 0) });
                    layerSelectionComboBox.DataSource = layers;
                    renderedMap.Dispose();
                    renderedMap = RenderLayers();
                    layerSelectionComboBox_SelectedValueChanged(this, new EventArgs());
                    mapPictureBox_Resize(this, new EventArgs());
                }
            }
        }
    }
}
