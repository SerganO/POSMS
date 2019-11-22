using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace posms
{
    [Serializable]
    public class ShopGood : ProviderGood
    {
        public double BuyPrice { get; set; }

        public ShopGood()
        {
            BuyPrice = 0;
        }

        public new static ShopGood randObject()
        {
            ShopGood good = new ShopGood();
            ProviderGood g = ProviderGood.randObject();

            Random r = new Random();
            good.Name = g.Name;
            good.Count = g.Count;
            good.SellPrice = g.SellPrice;
            good.BuyPrice = (r.Next() % 10000) / 100.0;
            good.Category = g.Category;
            Thread.Sleep(10);
            return good;
        }

        public override string ToString()
        {
            string res = base.ToString();

            res += "Buy Price: " + BuyPrice + Environment.NewLine;

            return res;
        }

        public bool equalWithProviderGood(ProviderGood good)
        {
            return Name == good.Name && BuyPrice == good.SellPrice;
        }
    }
}
