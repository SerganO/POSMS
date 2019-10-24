using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string ToString()
        {
            string res = base.ToString();

            res += "Buy Price: " + buyPrice + Environment.NewLine;

            return res;
        }
    }
}
