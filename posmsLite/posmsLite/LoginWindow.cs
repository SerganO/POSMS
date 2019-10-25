using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //Shop shop = Shop.randObject();
            //MainBase.Shops.Add(shop);


            //AccessBase.AccessDict.Add(new Credentionals("login1", "password1"), new Access("CR9cc3fc11-66e4-43e6-9c1a-00126920680f", "9e74c46e-4957-4927-af7b-ceee5a8bdcfa"));
            //AccessBase.AccessDict.Add(new Credentionals("login2", "password2"), new Access("CR9cc3fc11-66e4-43e6-9c1a-00126920680f", "73b53e94-ce4d-465b-8bde-a1e395be6bc8"));
            //AccessBase.AccessDict.Add(new Credentionals("login3", "password3"), new Access("CR9cc3fc11-66e4-43e6-9c1a-00126920680f", "d75a2db8-7cf0-4ebb-9ebd-b3ae5ed1ac1e"));
            //AccessBase.AccessDict.Add(new Credentionals("login4", "password4"), new Access("CR9cc3fc11-66e4-43e6-9c1a-00126920680f", "67a86dbc-84a4-475c-8a91-b4843e4bef29"));
            //AccessBase.AccessDict.Add(new Credentionals("login5", "password5"), new Access("CR9cc3fc11-66e4-43e6-9c1a-00126920680f", "5164383f-2bd0-4949-af64-d29e4affe6c0"));
            var shops = MainBase.Shops;
            var access = AccessBase.AccessDict;
            MainBase.Save();
            AccessBase.Save();
           // shop.Load();
            //shop.Providers = new List<Provider>();
            //shop.Users = new List<User>();
            //shop.Orders = new List<Order>();
            //shop.Goods = new List<ShopGood>();

           // shop.Providers.Add(new Provider());

            //shop.Save();
            //CheckText.Text += shop;

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
                var z = AccessBase.AccessDict;
                Access access = AccessBase.AccessDict[cred];

                Shop shop = MainBase.Shops.Find(x => x.UUID == access.shopUUID);

                if(shop != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }

            } catch
            {

            }
        }

        private void Sign_in_as_guest_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
