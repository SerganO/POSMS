using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posms
{
    class GoodToShow
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public GoodToShow(string name, int count, double price, GoodCategory category)
        {
            Name = name;
            Count = count;
            Price = price;
            Category = Converter.GoodCategoryToString(category);
        }
    }
}
