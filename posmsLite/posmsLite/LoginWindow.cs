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
            Access b = new Access();
            Access c = new Access();
            Access d = new Access();
            string s = "";
            s += "";

            Shop shop = Shop.randObject();
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
    }
}
