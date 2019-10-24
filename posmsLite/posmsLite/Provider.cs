using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace posmsLite
{
    [Serializable]
    class Provider
    {
        public string Name { get; set; }
        public string UUID { get; set; }
        public List<ProviderGood> Goods { get; set; }

        private static string[] randName = { "Goverla","Podolyanochka","Buvet","Obuhiv","BMK","Roshen","Khlibodar", "Nestle"}; 

        public Provider()
        {
            Name = "N/A";
            UUID = "N/A";
            Goods = new List<ProviderGood>();
        }

        public static Provider randObject()
        {
            Provider provider = new Provider();
            Random r = new Random();
            provider.Name = randName[r.Next() % randName.Length];
            provider.UUID = Guid.NewGuid().ToString();
            int n = r.Next() % 10;
            for (int i = 0; i <= n; i++)
            {
                provider.Goods.Add(ProviderGood.randObject());
            }
            Thread.Sleep(10);
            return provider;
        }

        public override string ToString()
        {
            string res = "";

            res += "Name: " + Name + Environment.NewLine;
            res += "UUID: " + UUID + Environment.NewLine;

            res += "Goods: "+ Environment.NewLine;
            foreach(ProviderGood good in Goods)
            {
                res += good + Environment.NewLine;
            }

            return res;
        }
    }
}
