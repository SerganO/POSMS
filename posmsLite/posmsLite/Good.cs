using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace posmsLite
{
    [Serializable]
    public class Good
    {
        public string Name { get; set; }
        public int Count { get; set; }

        private static string[] randName = { "Bread","Butter","Egg", "Water", "Sugar", "Salt", "Tea","Meat", "Chease", "Instant noodles", "Cake", "Toilet paper", "Soap", "Fish" };

        public Good()
        {
            Name = "N/A";
            Count = 0;
        }
        public static Good randObject()
        {
            Good good = new Good();
            Random r = new Random();
            good.Name = randName[r.Next() % randName.Length];
            good.Count = r.Next() % 201;
            Thread.Sleep(10);
            return good;
        }



        public override string ToString()
        {
            string res = "";

            res += "Name: " + Name + Environment.NewLine;
            res += "Count: " + Count + Environment.NewLine;

            return res;
        }

    }
}
