using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    [Serializable]
    class ProviderGood: Good
    {
        public double SellPrice { get; set; }

        public ProviderGood()
        {
            SellPrice = 0;
        }

        public override string ToString()
        {
            string res = base.ToString();
            res += "Sell price: " + SellPrice + Environment.NewLine;
            return res;
        }
    }
}
