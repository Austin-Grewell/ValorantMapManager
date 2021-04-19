namespace MapManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.assetsComboBox = new System.Windows.Forms.ComboBox();
            this.assetPictureBox = new System.Windows.Forms.PictureBox();
            this.assetsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scaledImageLabel = new System.Windows.Forms.Label();
            this.debugStatus = new System.Windows.Forms.Label();
            this.mousePosScaled = new System.Windows.Forms.Label();
            this.mousePosActual = new System.Windows.Forms.Label();
            this.primaryVerticalLayout = new System.Windows.Forms.TableLayoutPanel();
            this.layersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.layerPreviewPictureBox = new System.Windows.Forms.PictureBox();
            this.layerSelectionButtonPanel = new System.Windows.Forms.Panel();
            this.layerEditButton = new System.Windows.Forms.Button();
            this.layerSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPictureBox)).BeginInit();
            this.assetsLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.primaryVerticalLayout.SuspendLayout();
            this.layersTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layerPreviewPictureBox)).BeginInit();
            this.layerSelectionButtonPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("mapPictureBox.Image")));
            this.mapPictureBox.Location = new System.Drawing.Point(235, 3);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(831, 681);
            this.mapPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            this.mapPictureBox.Click += new System.EventHandler(this.mapPictureBox_Click);
            this.mapPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapPictureBox_MouseMove);
            this.mapPictureBox.Resize += new System.EventHandler(this.mapPictureBox_Resize);
            // 
            // assetsComboBox
            // 
            this.assetsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetsComboBox.FormattingEnabled = true;
            this.assetsComboBox.Location = new System.Drawing.Point(3, 508);
            this.assetsComboBox.Name = "assetsComboBox";
            this.assetsComboBox.Size = new System.Drawing.Size(220, 21);
            this.assetsComboBox.TabIndex = 1;
            this.assetsComboBox.SelectedIndexChanged += new System.EventHandler(this.assetsComboBox_SelectedIndexChanged);
            // 
            // assetPictureBox
            // 
            this.assetPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetPictureBox.Location = new System.Drawing.Point(3, 3);
            this.assetPictureBox.Name = "assetPictureBox";
            this.assetPictureBox.Size = new System.Drawing.Size(220, 499);
            this.assetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.assetPictureBox.TabIndex = 2;
            this.assetPictureBox.TabStop = false;
            this.assetPictureBox.Click += new System.EventHandler(this.assetPictureBox_Click);
            // 
            // assetsLayoutPanel
            // 
            this.assetsLayoutPanel.AutoSize = true;
            this.assetsLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.assetsLayoutPanel.ColumnCount = 1;
            this.assetsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.assetsLayoutPanel.Controls.Add(this.assetsComboBox, 0, 1);
            this.assetsLayoutPanel.Controls.Add(this.assetPictureBox, 0, 0);
            this.assetsLayoutPanel.Controls.Add(this.panel1, 0, 2);
            this.assetsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assetsLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.assetsLayoutPanel.Name = "assetsLayoutPanel";
            this.assetsLayoutPanel.RowCount = 3;
            this.assetsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.assetsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.assetsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.assetsLayoutPanel.Size = new System.Drawing.Size(226, 681);
            this.assetsLayoutPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scaledImageLabel);
            this.panel1.Controls.Add(this.debugStatus);
            this.panel1.Controls.Add(this.mousePosScaled);
            this.panel1.Controls.Add(this.mousePosActual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 535);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 143);
            this.panel1.TabIndex = 3;
            // 
            // scaledImageLabel
            // 
            this.scaledImageLabel.AutoSize = true;
            this.scaledImageLabel.Location = new System.Drawing.Point(4, 67);
            this.scaledImageLabel.Name = "scaledImageLabel";
            this.scaledImageLabel.Size = new System.Drawing.Size(95, 13);
            this.scaledImageLabel.TabIndex = 3;
            this.scaledImageLabel.Text = "Scaled Image Size";
            // 
            // debugStatus
            // 
            this.debugStatus.AutoSize = true;
            this.debugStatus.Location = new System.Drawing.Point(4, 50);
            this.debugStatus.Name = "debugStatus";
            this.debugStatus.Size = new System.Drawing.Size(101, 13);
            this.debugStatus.TabIndex = 2;
            this.debugStatus.Text = "Debug Status Label";
            // 
            // mousePosScaled
            // 
            this.mousePosScaled.AutoSize = true;
            this.mousePosScaled.Location = new System.Drawing.Point(3, 33);
            this.mousePosScaled.Name = "mousePosScaled";
            this.mousePosScaled.Size = new System.Drawing.Size(121, 13);
            this.mousePosScaled.TabIndex = 1;
            this.mousePosScaled.Text = "mousePosScaled - X: Y:";
            // 
            // mousePosActual
            // 
            this.mousePosActual.AutoSize = true;
            this.mousePosActual.Location = new System.Drawing.Point(3, 10);
            this.mousePosActual.Name = "mousePosActual";
            this.mousePosActual.Size = new System.Drawing.Size(118, 13);
            this.mousePosActual.TabIndex = 0;
            this.mousePosActual.Text = "mousePosActual - X: Y:";
            // 
            // primaryVerticalLayout
            // 
            this.primaryVerticalLayout.AutoSize = true;
            this.primaryVerticalLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.primaryVerticalLayout.ColumnCount = 3;
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.primaryVerticalLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.primaryVerticalLayout.Controls.Add(this.assetsLayoutPanel, 0, 0);
            this.primaryVerticalLayout.Controls.Add(this.mapPictureBox, 1, 0);
            this.primaryVerticalLayout.Controls.Add(this.layersTableLayoutPanel, 2, 0);
            this.primaryVerticalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.primaryVerticalLayout.Location = new System.Drawing.Point(0, 24);
            this.primaryVerticalLayout.Name = "primaryVerticalLayout";
            this.primaryVerticalLayout.RowCount = 1;
            this.primaryVerticalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.primaryVerticalLayout.Size = new System.Drawing.Size(1275, 663);
            this.primaryVerticalLayout.TabIndex = 5;
            // 
            // layersTableLayoutPanel
            // 
            this.layersTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layersTableLayoutPanel.ColumnCount = 1;
            this.layersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layersTableLayoutPanel.Controls.Add(this.layerPreviewPictureBox, 0, 0);
            this.layersTableLayoutPanel.Controls.Add(this.layerSelectionButtonPanel, 0, 1);
            this.layersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layersTableLayoutPanel.Location = new System.Drawing.Point(1072, 3);
            this.layersTableLayoutPanel.Name = "layersTableLayoutPanel";
            this.layersTableLayoutPanel.RowCount = 2;
            this.layersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 568F));
            this.layersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.layersTableLayoutPanel.Size = new System.Drawing.Size(200, 681);
            this.layersTableLayoutPanel.TabIndex = 5;
            // 
            // layerPreviewPictureBox
            // 
            this.layerPreviewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layerPreviewPictureBox.Location = new System.Drawing.Point(3, 3);
            this.layerPreviewPictureBox.Name = "layerPreviewPictureBox";
            this.layerPreviewPictureBox.Size = new System.Drawing.Size(194, 562);
            this.layerPreviewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.layerPreviewPictureBox.TabIndex = 0;
            this.layerPreviewPictureBox.TabStop = false;
            // 
            // layerSelectionButtonPanel
            // 
            this.layerSelectionButtonPanel.Controls.Add(this.layerEditButton);
            this.layerSelectionButtonPanel.Controls.Add(this.layerSelectionComboBox);
            this.layerSelectionButtonPanel.Location = new System.Drawing.Point(3, 571);
            this.layerSelectionButtonPanel.Name = "layerSelectionButtonPanel";
            this.layerSelectionButtonPanel.Size = new System.Drawing.Size(194, 107);
            this.layerSelectionButtonPanel.TabIndex = 1;
            // 
            // layerEditButton
            // 
            this.layerEditButton.Location = new System.Drawing.Point(54, 44);
            this.layerEditButton.Name = "layerEditButton";
            this.layerEditButton.Size = new System.Drawing.Size(75, 23);
            this.layerEditButton.TabIndex = 2;
            this.layerEditButton.Text = "Edit";
            this.layerEditButton.UseVisualStyleBackColor = true;
            this.layerEditButton.Click += new System.EventHandler(this.layerEditButton_Click);
            // 
            // layerSelectionComboBox
            // 
            this.layerSelectionComboBox.FormattingEnabled = true;
            this.layerSelectionComboBox.Location = new System.Drawing.Point(0, 0);
            this.layerSelectionComboBox.Name = "layerSelectionComboBox";
            this.layerSelectionComboBox.Size = new System.Drawing.Size(194, 21);
            this.layerSelectionComboBox.TabIndex = 1;
            this.layerSelectionComboBox.SelectedValueChanged += new System.EventHandler(this.layerSelectionComboBox_SelectedValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1275, 687);
            this.Controls.Add(this.primaryVerticalLayout);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPictureBox)).EndInit();
            this.assetsLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.primaryVerticalLayout.ResumeLayout(false);
            this.primaryVerticalLayout.PerformLayout();
            this.layersTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layerPreviewPictureBox)).EndInit();
            this.layerSelectionButtonPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.ComboBox assetsComboBox;
        private System.Windows.Forms.PictureBox assetPictureBox;
        private System.Windows.Forms.TableLayoutPanel assetsLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel primaryVerticalLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mousePosScaled;
        private System.Windows.Forms.Label mousePosActual;
        private System.Windows.Forms.TableLayoutPanel layersTableLayoutPanel;
        private System.Windows.Forms.PictureBox layerPreviewPictureBox;
        private System.Windows.Forms.ComboBox layerSelectionComboBox;
        private System.Windows.Forms.Label debugStatus;
        private System.Windows.Forms.Label scaledImageLabel;
        private System.Windows.Forms.Panel layerSelectionButtonPanel;
        private System.Windows.Forms.Button layerEditButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

