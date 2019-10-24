using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace posmsLite
{
    [Serializable]
    class ShopGood: ProviderGood
    {
        public double buyPrice { get; set; }

        public ShopGood()
        {
            buyPrice = 0;
        }

        public new static ShopGood randObject()
        {
            ShopGood good = new ShopGood();
            ProviderGood g = ProviderGood.randObject();

            Random r = new Random();
            good.Name = g.Name;
            good.Count = g.Count;
            good.SellPrice = g.SellPrice;
            good.buyPrice = (r.Next() % 10000) / 100.0;
            Thread.Sleep(10);
            return good;
        }

        public override string ToString()
        {
            string res = base.ToString();

            res += "Buy Price: " + buyPrice + Environment.NewLine;

            return res;
        }
    }
}
