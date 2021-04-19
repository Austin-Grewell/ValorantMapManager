using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    public static class AssetFactory
    {

        public static IEnumerable<Asset> Construct(string assetDirectory)
        {
            IList<Asset> assets = new List<Asset>();
            var allAssetPaths = Directory.EnumerateFiles(assetDirectory, "*.png", SearchOption.AllDirectories);

            foreach(var assetPath in allAssetPaths)
            {
                string name = assetPath.Replace(assetDirectory, string.Empty).Replace(".png", string.Empty);
                assets.Add(new Asset(assetPath) { Name = name });
            }

            return assets;
        }
    }
}
