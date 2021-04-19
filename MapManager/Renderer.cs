using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    using System.Collections.Generic;
    using System.Drawing;

    public class Renderer
    {
        public static Bitmap RenderLayers(IEnumerable<Layer> layers, int width, int height)
        {
            // This is the base layer on top of which all images will be rendered
            Bitmap render = new Bitmap(width, height);

            foreach (Layer layer in layers)
            {
                using (Graphics combiner = Graphics.FromImage(render))
                {
                    combiner.DrawImage(layer.Current, layer.Location);
                }
            }

            return render;
        }

        public static Size Scale(Size original, double growPercent)
        {
            int newWidth = (int)(original.Width * growPercent);
            int newHeight = (int)(original.Height * growPercent);
            return new Size(newWidth, newHeight);
        }
    }
}
