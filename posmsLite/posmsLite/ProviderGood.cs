﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace posmsLite
{
    [Serializable]
    public class ProviderGood: Good
    {
        public double SellPrice { get; set; }

        public ProviderGood()
        {
            SellPrice = 0;
        }

        public ProviderGood(string name, int count, double price)
        {
            Name = name;
            Count = count;
            SellPrice = price;
        }

        public new static ProviderGood randObject()
        {
            ProviderGood good = new ProviderGood();
            Good g = Good.randObject();

            Random r = new Random();
            good.Name = g.Name;
            good.Count = g.Count;
            good.SellPrice = (r.Next() % 15000) / 100.0;
            good.Category = g.Category;
            Thread.Sleep(10);
            return good;
        }

        public override string ToString()
        {
            string res = base.ToString();
            res += "Sell price: " + SellPrice + Environment.NewLine;
            return res;
        }

        public string StringForOrderList()
        {
            string res = "";

            res += Name + " Price: " + SellPrice;

            return res;
        }
    }
}
