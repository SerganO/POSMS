using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace posms
{
    [Serializable]
    public class Order
    {
        public List<ProviderGood> goods { get; set; }
        public bool status { get; set; }
        public string ID { get; set; }

        public Order()
        {
            status = false;
            goods = new List<ProviderGood>();
            ID = Guid.NewGuid().ToString();
        }

        public double SummPrice
        {
            get
            {
                double summ = 0;
                foreach (ProviderGood good in goods)
                {
                    summ += good.SellPrice * good.Count;
                }
                return summ;
            }
        }


        public static Order randObject()
        {
            Order order = new Order();
            Random r = new Random();
            int n = r.Next() % 10;
            for (int i = 0; i <= n; i++)
            {
                order.goods.Add(ProviderGood.randObject());
            }
            order.status = false;
            order.ID = Guid.NewGuid().ToString();
            Thread.Sleep(10);
            return order;
        }

        public override string ToString()
        {
            string res = "";

            res += "Status: " + (status ? "Delivered" : "Not Delivered") + Environment.NewLine;
            res += "Goods: " + Environment.NewLine;
            foreach (ProviderGood good in goods)
            {
                res += good + Environment.NewLine;
            }


            return res;
        }
    }
}
