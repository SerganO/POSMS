using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace posms
{
    [Serializable]
    public class User
    {
        public enum Roles
        {
            Admin, Quartemaster
        }

        private static string[] randName = { "Novak V.V.", "Stepanenko O.I.", "Brinzey O.A.", "Sherbak A.S.", "Ostrovetskiy S.V.", "Didyk I.V." };

        public string Name { get; set; }
        public string UUID { get; set; }
        public Roles Role { get; set; }

        public User()
        {
            Name = "N/A";
            UUID = "N/A";
            Role = new Roles();
        }

        public static User randObject()
        {
            User user = new User();
            Random r = new Random();
            user.Name = randName[r.Next() % randName.Length];
            user.UUID = Guid.NewGuid().ToString();
            user.Role = r.Next() % 2 == 0 ? Roles.Admin : Roles.Quartemaster;
            Thread.Sleep(10);
            return user;
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
