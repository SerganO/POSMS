﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    [Serializable]
    class User
    {
        public enum Role {
            Admin, Quartemaster
        }


        public string Name { get; set; }
        public string UUID { get; set; }
        public Role role { get; set; }
    }
}
