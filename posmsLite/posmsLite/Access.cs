using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    class Access
    {
        string shopUUID { get; set; }
        string userUUID { get; set; }
        public Access()
        {
            shopUUID = Guid.NewGuid().ToString();
            userUUID = Guid.NewGuid().ToString();
        }
    }
}
