using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

        public static Order randObject()
        {
            Order order = new Order();
            Random r = new Random();
            int n = r.Next() % 10;
            for(int i =0; i <= n; i++)
            {
                order.goods.Add(ProviderGood.randObject());
            }
            order.status = false;
            Thread.Sleep(10);
            return order;
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


            return res;
        }
    }
}
