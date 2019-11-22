using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posms
{
    static class LoginManager
    {
        public static bool isGuest = false;
        public static bool isAuthUser = false;
        public static User CurrentUser;
        public static Shop CurrentShop;

        static public void loginAs(User user, Shop shop)
        {
            CurrentUser = user;
            CurrentShop = shop;
            isAuthUser = true;
            isGuest = false;

        }

        static public void loginAsGuest()
        {
            CurrentUser = null;
            CurrentShop = null;
            isAuthUser = false;
            isGuest = true;
        }

        static public void logout()
        {
            CurrentUser = null;
            CurrentShop = null;
            isAuthUser = false;
            isGuest = false;
        }

    }
}
