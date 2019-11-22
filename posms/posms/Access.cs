using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posms
{
    [Serializable]
    class Access
    {
        public string shopUUID { get; set; }
        public string userUUID { get; set; }
        public Access()
        {
            shopUUID = Guid.NewGuid().ToString();
            userUUID = Guid.NewGuid().ToString();
        }

        public Access(string shop, string user)
        {
            shopUUID = shop;
            userUUID = user;
        }

        public override bool Equals(object obj)
        {
            if (obj is Access)
            {
                Access a = obj as Access;


                return shopUUID == a.shopUUID && userUUID == a.userUUID;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return shopUUID.Length + userUUID.Length;
        }
    }
}
