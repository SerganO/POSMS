using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    [Serializable]
    class Order
    {
        public List<ProviderGood> goods { get; set; }
        public bool status { get; set; }

        public Order()
        {
            status = false;
            goods = new List<ProviderGood>();
        }

        public override string ToString()
        {
            string res = "";

            res += "Status: " + (status ? "Delivered" : "Not Delivered") + Environment.NewLine;
            res += "Goods: " + Environment.NewLine;
            foreach(ProviderGood good in goods)
            {
                res += good + Environment.NewLine;
            }


            return base.ToString();
        }
    }
}
