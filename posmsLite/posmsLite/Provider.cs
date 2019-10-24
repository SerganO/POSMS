﻿using System;
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
    }
}
