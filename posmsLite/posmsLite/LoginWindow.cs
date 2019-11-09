using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace posmsLite
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
            Access a = new Access();

            MainBase.Load();
            AccessBase.Load();

            //for (int i = 0; i < 2; i++)
            //{

            //    Shop shop = Shop.RandObject();
            //    MainBase.Shops.Add(shop);

            //    foreach (User user in shop.Users)
            //    {
            //        AccessBase.AccessDict.Add(new Credentionals("login" + AccessBase.Count, "password" + AccessBase.Count), new Access(shop.UUID, user.UUID));
            //    }

            //    MainBase.Save();
            //    AccessBase.Save();

            //}

            var shops = MainBase.Shops;
            var access = AccessBase.AccessDict;
        }

        private void CheckText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_label_Click(object sender, EventArgs e)
        {

        }

        private void or_label_Click(object sender, EventArgs e)
        {

        }

        private void Sign_in_as_employee_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            

            try
            {
                Credentionals cred = new Credentionals(login, password);
                Access access = AccessBase.AccessDict[cred];

                Shop shop = MainBase.Shops.Find(x => x.UUID == access.shopUUID);

                if(shop != null)
                {
                    User user = shop.Users.Find(x => x.UUID == access.userUUID);
                    if(user != null)
                    {
                        LoginManager.loginAs(user, shop);
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.ShowDialog();
                    }
                }

            } catch
            {

            }
        }

        private void Sign_in_as_guest_Click(object sender, EventArgs e)
        {
            LoginManager.loginAsGuest();
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            MainBase.Load();
            AccessBase.Load();
            generateProgreesBar.Value = 0;
            string fileName = "shopInfo.txt";
            FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);
            aFile.Seek(0, SeekOrigin.End);
            generateProgreesBar.Maximum = 10;
            for (int i = 0; i < 10; i++)
            {

                Shop shop = Shop.RandObject();
                MainBase.Shops.Add(shop);
                sw.WriteLine(MainBase.Count);
                sw.WriteLine(shop.ShortInfo());
                foreach (User user in shop.Users)
                {
                    AccessBase.AccessDict.Add(new Credentionals("login" + AccessBase.Count, "password" + AccessBase.Count), new Access(shop.UUID, user.UUID));
                }

                MainBase.Save();
                AccessBase.Save();
                generateProgreesBar.Value += 1;
            }
            sw.Close();
        }
    }
}
