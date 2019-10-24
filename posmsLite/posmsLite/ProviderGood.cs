using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    [Serializable]
    class ProviderGood: Good
    {
        public double SellPrice { get; set; }
    }
}
