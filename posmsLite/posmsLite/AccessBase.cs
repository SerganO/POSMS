using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace posmsLite
{
    [Serializable]
    class AccessBase
    {
        public static Dictionary<Credentionals, Access> AccessDict = new Dictionary<Credentionals, Access>();
        public static int Count {
            get { return AccessDict.Count; }
        }


        public static void Save()
        {
            FileStream fileStream = new FileStream("accessBase.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, AccessDict);
            fileStream.Close();
        }

        public static void Load()
        {
            
                FileStream fileStream = new FileStream("accessBase.txt", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                AccessDict = (Dictionary<Credentionals, Access>)formatter.Deserialize(fileStream);
            }
            catch
            {

            }
                fileStream.Close();
            
        }
    }
}
