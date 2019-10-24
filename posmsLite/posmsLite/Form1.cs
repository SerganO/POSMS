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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Access a = new Access();
            Access b = new Access();
            Access c = new Access();
            Access d = new Access();
            string s = "";
            s += "";

            Shop shop = new Shop();
            shop.Load();
            //shop.Providers = new List<Provider>();
            //shop.Users = new List<User>();
            //shop.Orders = new List<Order>();
            //shop.Goods = new List<ShopGood>();

            shop.Providers.Add(new Provider());

            shop.Save();
            CheckText.Text += shop;

        }
    }
}
