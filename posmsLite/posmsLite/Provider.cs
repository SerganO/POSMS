using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    [Serializable]
    class Provider
    {
        public string Name { get; set; }
        public string UUID { get; set; }
        public List<ProviderGood> Goods { get; set; }

        public Provider()
        {
            Name = "N/A";
            UUID = "N/A";
            Goods = new List<ProviderGood>();
        }

        public override string ToString()
        {
            string res = "";

            res += "Name: " + Name + Environment.NewLine;
            res += "UUID: " + UUID + Environment.NewLine;

            res += "Goods: "+ Environment.NewLine;
            foreach(ProviderGood good in Goods)
            {
                res += good + Environment.NewLine;
            }

            return res;
        }
    }
}
