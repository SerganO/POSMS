using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    [Serializable]
    class User
    {
        public enum Roles {
            Admin, Quartemaster, None
        }


        public string Name { get; set; }
        public string UUID { get; set; }
        public Roles Role { get; set; }

        public User()
        {
            Name = "N/A";
            UUID = "N/A";
            Role = Roles.None;
        }

        public override string ToString()
        {
            string res = "";

            res += "Name: " + Name + Environment.NewLine;
            res += "UUID: " + UUID + Environment.NewLine;
            res += "Role: " + Role + Environment.NewLine;


            return res;
        }
    }
}
