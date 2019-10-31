using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    class GoodToShow
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public GoodToShow(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}
