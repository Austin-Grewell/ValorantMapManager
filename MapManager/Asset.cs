using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapManager
{
    using System.IO;
    public class Asset : IEquatable<Asset>
    {

        public Asset(string filePath)
        {
            FilePath = filePath;
            Name = Path.GetFileNameWithoutExtension(filePath);
        }

        public string Name { get; set; }

        public string FilePath { get; set; }

        public override int GetHashCode()
        {
            return FilePath.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Asset);
        }

        public bool Equals(Asset other)
        {
            bool isEqual = false;

            if(other == null)
            {
                isEqual = false;
            }
            else if(other.GetHashCode() == GetHashCode())
            {
                if (other.FilePath.Equals(FilePath) && other.Name.Equals(Name))
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }

        public override string ToString()
        {
            return FilePath;
        }
    }
}
