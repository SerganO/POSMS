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
    public enum Region {



    }

    [Serializable]
    class Shop
    {
        public string Name { get; set; }
        public Region Region { get; set; }
        public string UUID { get; set; }
        public List<User> Users { get; set; }
        public List<Provider> Providers { get; set; }
        public List<ShopGood> Goods { get; set; }
        public List<Order> Orders { get; set; }



        public void Save()
        {
            FileStream fileStream = new FileStream("user.gd", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, this);
            fileStream.Close();
        }

        public void Save(string filename)
        {
            FileStream fileStream = new FileStream(filename, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, this);
            fileStream.Close();
        }

        public void Load()
        {
            FileStream fileStream = new FileStream("user.gd", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Shop loaded = (Shop)formatter.Deserialize(fileStream);
            Providers = loaded.Providers;
            Users = loaded.Users;
            Goods = loaded.Goods;
            Orders = loaded.Orders;
            fileStream.Close();
        }

        public void Load(string filename)
        {
            FileStream fileStream = new FileStream(filename, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Shop loaded = (Shop)formatter.Deserialize(fileStream);
            Providers = loaded.Providers;
            Users = loaded.Users;
            Goods = loaded.Goods;
            Orders = loaded.Orders;
            fileStream.Close();
        }

        public string Show()
        {
            string res = "";



            return res;
        }
    }


}
