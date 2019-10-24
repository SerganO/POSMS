using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    [Serializable]
    class Order
    {
        public List<ProviderGood> goods { get; set; }
        public bool status { get; set; }
    }
}
