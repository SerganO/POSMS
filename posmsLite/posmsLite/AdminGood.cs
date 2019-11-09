using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    class AdminGood
    {
        public string Name { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        public string Category { get; set; }
        public int count;
        public ShopGood getGood()
        {
            return new ShopGood { Name = Name, BuyPrice = Buy, SellPrice = Sell, Count = count, Category = Converter.StringToGoodCategory(Category) };

        }

    }
}
