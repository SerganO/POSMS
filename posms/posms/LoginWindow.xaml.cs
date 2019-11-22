using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace posms
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            Access a = new Access();

            MainBase.Load();
            AccessBase.Load();

            //string fileName = "shopInfo.txt";
            //FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate);
            //StreamWriter sw = new StreamWriter(aFile);
            //aFile.Seek(0, SeekOrigin.End);
            //for (int i = 0; i < 10; i++)
            //{

            //    Shop shop = Shop.RandObject();
            //    MainBase.Shops.Add(shop);
            //    sw.WriteLine(MainBase.Count);
            //    sw.WriteLine(shop.ShortInfo());
            //    foreach (User user in shop.Users)
            //    {
            //        AccessBase.AccessDict.Add(new Credentionals("login" + AccessBase.Count, "password" + AccessBase.Count), new Access(shop.UUID, user.UUID));
            //    }

            //    MainBase.Save();
            //    AccessBase.Save();
            //}
            //sw.Close();

            var shops = MainBase.Shops;
            var access = AccessBase.AccessDict;
        }

        private void Click_employee(object sender, RoutedEventArgs e)
        {
            string login = Name.Text;

            string password = Password.Password ;


            try
            {
                Credentionals cred = new Credentionals(login, password);
                Access access = AccessBase.AccessDict[cred];

                Shop shop = MainBase.Shops.Find(x => x.UUID == access.shopUUID);

                if (shop != null)
                {
                    User user = shop.Users.Find(x => x.UUID == access.userUUID);
                    if (user != null)
                    {
                        LoginManager.loginAs(user, shop);
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.ShowDialog();
                    }
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Invalid password or login", "Oops", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Click_guest(object sender, RoutedEventArgs e)
        {
            LoginManager.loginAsGuest();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }
    }
}
