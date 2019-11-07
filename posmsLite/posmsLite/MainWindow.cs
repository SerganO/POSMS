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
    public partial class MainWindow : Form
    {
        int regionIndex = -1;
        int shopIndex = -1;
        List<Shop> regionsShops;
        Shop selectedShop;
        public MainWindow()
        {
            InitializeComponent();
            selectedShop = new Shop();
            regionIndex = -1;
            shopIndex = -1;
            List_shop.Enabled = false;
            Search_in_database.Enabled = false;
            if (LoginManager.isAuthUser)
            {
                switch (LoginManager.CurrentUser.Role) {
                    case User.Roles.Admin:
                        quartermasterBox.Visible = false;
                        adminBox.Visible = true;
                        Name_Admin_Label.Text = LoginManager.CurrentUser.Name;
                        Name_Admin_Shop_label.Text = LoginManager.CurrentShop.Name;
                        break;
                    case User.Roles.Quartemaster:
                        quartermasterBox.Visible = true;
                        adminBox.Visible = false;
                        Name_Quarter_label.Text = LoginManager.CurrentUser.Name;
                        Name_Shop_label.Text = LoginManager.CurrentShop.Name;
                        break;
                    default:
                        quartermasterBox.Visible = false;
                        adminBox.Visible = false;
                        break;

                }

            }
        }

        private void Back_to_login_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void List_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            regionIndex = List_region.SelectedIndex;
            Region checkedRegion = Converter.StringToRegion((List_region.Items[regionIndex].ToString()));
            regionsShops = MainBase.Shops.Where(x => x.Region == checkedRegion).ToList();
            //foreach(var item in List_shop.Items)
            //{
            //    List_shop.Items.Remove(item);
            //}
            while(List_shop.Items.Count != 0)
            {
                List_shop.Items.Remove(List_shop.Items[0]);
            }
            foreach(Shop shop in regionsShops)
            {
                List_shop.Items.Add(shop.Name);
            }
            List_shop.Enabled = true;
        }

        private void Search_in_database_Click(object sender, EventArgs e)
        {
            
            ShopInfo shopInfoWindow = new ShopInfo(selectedShop);
            shopInfoWindow.ShowDialog();
        }

        private void List_shop_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_in_database.Enabled = true;
            shopIndex = List_shop.SelectedIndex;
            try
            {
                selectedShop = regionsShops[shopIndex];
            } catch
            {

            }
        }

        private void Order_goods_Click(object sender, EventArgs e)
        {
            OrderGoods orders = new OrderGoods();
            orders.ShowDialog();
        }

        private void Orders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void QShop_Click(object sender, EventArgs e)
        {
            ShopInfo shopInfoWindow = new ShopInfo(LoginManager.CurrentShop);
            shopInfoWindow.ShowDialog();
        }

        private void Set_prices_Click(object sender, EventArgs e)
        {
            SetPrices setPrices = new SetPrices();
            setPrices.ShowDialog();
        }

        private void Shop_Click(object sender, EventArgs e)
        {
            ShopInfo shopInfoWindow = new ShopInfo(LoginManager.CurrentShop);
            shopInfoWindow.ShowDialog();
        }

        private void Price_monitoring_Click(object sender, EventArgs e)
        {
            PriceMonitoringWindow priceMonitoring = new PriceMonitoringWindow();
            priceMonitoring.ShowDialog();
        }
    }
}
