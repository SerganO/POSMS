using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace posms
{
    [Serializable]
    class MainBase
    {
        public static List<Shop> Shops = new List<Shop>();
        public static int Count
        {
            get { return Shops.Count; }
        }
        public static void Save()
        {
            FileStream fileStream = new FileStream("mainBase.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, Shops);
            fileStream.Close();
        }

        public static void Load()
        {
            FileStream fileStream = new FileStream("mainBase.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                Shops = (List<Shop>)formatter.Deserialize(fileStream);
            }
            catch
            {

            }
            fileStream.Close();
        }
    }
}
