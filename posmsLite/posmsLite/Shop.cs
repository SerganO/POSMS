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

        public Shop()
        {
            Name = "N/A";
            //Region =;
            UUID = "";
            Users = new List<User>();
            Providers = new List<Provider>();
            Goods = new List<ShopGood>();
            Orders = new List<Order>();
        }

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

        public override string ToString()
        {
            string res = "";
            res += "Name: " + Name + Environment.NewLine;
            res += "Region: " + Region + Environment.NewLine;
            res += "UUID: " + UUID + Environment.NewLine;

            res += "Users: " + Environment.NewLine;
            foreach (User user in Users)
            {
                res += user + Environment.NewLine;
            }

            res += "Providers: " + Environment.NewLine;
            foreach (Provider provider in Providers)
            {
                res += provider + Environment.NewLine;
            }

            res += "Goods: " + Environment.NewLine;
            foreach (ShopGood good in Goods)
            {
                res += good + Environment.NewLine;
            }

            res += "Orders: " + Environment.NewLine;
            foreach (Order order in Orders)
            {
                res += order + Environment.NewLine;
            }


            return res;
        }
    }


}
