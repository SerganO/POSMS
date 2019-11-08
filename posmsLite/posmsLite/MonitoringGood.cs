using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    class MonitoringGood
    {
        public string ShopName { get; set; }
        public string Name { get { return good.Name; } }
        public int Count { get { return good.Count; } }
        public double Price { get { return good.Price; } }
        public GoodToShow good;
    }
}
