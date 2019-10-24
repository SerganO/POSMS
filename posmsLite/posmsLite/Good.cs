using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    [Serializable]
    class Good
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public Good()
        {
            Name = "N/A";
            Count = 0;
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
