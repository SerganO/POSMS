using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace posmsLite
{
    [Serializable]
    public enum Region {
        LT, LV, UZ, RV, TE, IF, CV, KM, ZT, VN, KV, CK, KR, MK, OD, CR, KS, DP, PL, CN, SM, KH, DN, ZP, LG


    }

   



    [Serializable]
    public class Shop
    {
        public string Name { get; set; }
        public Region Region { get; set; }
        public string UUID { get; set; }
        public List<User> Users { get; set; }
        public List<Provider> Providers { get; set; }
        public List<ShopGood> Goods { get; set; }
        public List<Order> Orders { get; set; }

        private static string[] randName = {"ATB","SILPO", "Apelmon", "VARUS", "Brusnichka", "TavriaV", "Ashan" };

        public Shop()
        {
            Name = "N/A";
            Region = new Region();
            UUID = "";
            Users = new List<User>();
            Providers = new List<Provider>();
            Goods = new List<ShopGood>();
            Orders = new List<Order>();
        }

        public static Shop RandObject()
        {
            Shop shop = new Shop();
            Random r = new Random();
            shop.Name = randName[r.Next() % randName.Length];
            int n = r.Next() % 50;
            for (int i = 0; i <= n; i++)
            {
                shop.Goods.Add(ShopGood.randObject());
            }
            n = r.Next() % 10 + 1;
            for (int i = 0; i <= n; i++)
            {
                shop.Providers.Add(Provider.randObject());
            }
            n = r.Next() % 3 + 2;
            for (int i = 0; i <= n; i++)
            {
                shop.Users.Add(User.randObject());
            }
            n = r.Next() % 20 + 2;
            for (int i = 0; i <= n; i++)
            {
                shop.Orders.Add(Order.randObject());
            }
            n = r.Next() % 25;
            shop.Region = (Region)n;
            shop.UUID = Guid.NewGuid().ToString();
            shop.UUID = shop.Region.ToString() + shop.UUID;
            Thread.Sleep(10);
            return shop;
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


        public void AddProviderGoodToGoods(ProviderGood good)
        {
            ShopGood shopGood = new ShopGood
            {
                BuyPrice = good.SellPrice,
                Name = good.Name,
                Count = good.Count,
                SellPrice = good.SellPrice
            };
            Goods.Add(shopGood);
        }
    }


}
