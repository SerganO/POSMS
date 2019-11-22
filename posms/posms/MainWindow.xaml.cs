using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace posms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //int regionIndex = -1;
        int shopIndex = -1;
        List<Shop> regionsShops;
        Shop selectedShop;

        public MainWindow()
        {
            InitializeComponent();
            selectedShop = new Shop();
            //regionIndex = -1;
            shopIndex = -1;
            List_Shop.IsEnabled = false;
            Search_in_database.IsEnabled = false;
            if (LoginManager.isAuthUser)
            {
                switch (LoginManager.CurrentUser.Role)
                {
                    case User.Roles.Admin:
                        Quartemaster.Visibility = Visibility.Collapsed;
                        Guest.Visibility = Visibility.Collapsed;
                        Admin.Visibility = Visibility.Visible;
                        AdminName.Text = LoginManager.CurrentUser.Name;
                        AdminShopName.Text = LoginManager.CurrentShop.Name;
                        break;
                    case User.Roles.Quartemaster:
                        Quartemaster.Visibility = Visibility.Visible;
                        Guest.Visibility = Visibility.Collapsed;
                        Admin.Visibility = Visibility.Collapsed;
                        QuartemasterName.Text = LoginManager.CurrentUser.Name;
                        QuartemasterShopName.Text = LoginManager.CurrentShop.Name;
                        break;
                    default:
                        Quartemaster.Visibility = Visibility.Collapsed;
                        Guest.Visibility = Visibility.Visible;
                        Admin.Visibility = Visibility.Collapsed;
                        break;

                }

            }
            EventManager.RegisterClassHandler(typeof(Image), Image.MouseDownEvent, new RoutedEventHandler(Exit_to_login_window));
        }


        private void Exit_to_login_window(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Go_to_shop_window(object sender, RoutedEventArgs e)
        {
            ShopInfo shopInfoWindow = new ShopInfo(LoginManager.CurrentShop);
            shopInfoWindow.ShowDialog();
        }

        private void Search_in_database_Click(object sender, RoutedEventArgs e)
        {
            ShopInfo shopInfoWindow = new ShopInfo(selectedShop);
            shopInfoWindow.ShowDialog();
        }

        private void List_Shop_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Search_in_database.IsEnabled = true;
            shopIndex = List_Shop.SelectedIndex;
            try
            {
                selectedShop = regionsShops[shopIndex];
            }
            catch
            {

            }
        }

        private void List_Region_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var res = ((ComboBoxItem)(((ComboBox)sender).SelectedItem)).Content;
            Region checkedRegion = Converter.StringToRegion((res.ToString()));
            regionsShops = MainBase.Shops.Where(x => x.Region == checkedRegion).ToList();
            //foreach(var item in List_shop.Items)
            //{
            //    List_shop.Items.Remove(item);
            //}
            while (List_Shop.Items.Count != 0)
            {
                List_Shop.Items.Remove(List_Shop.Items[0]);
            }
            foreach (Shop shop in regionsShops)
            {
                List_Shop.Items.Add(shop.Name);
            }
            List_Shop.IsEnabled = true;
        }

        private void OrderGoods_Click(object sender, MouseButtonEventArgs e)
        {
            OrderGoods orders = new OrderGoods();
            orders.ShowDialog();
        }

        private void Price_monitoring_Click(object sender, RoutedEventArgs e)
        {
            PriceMonitoringWindow priceMonitoring = new PriceMonitoringWindow();
            priceMonitoring.ShowDialog();
        }

        private void Orders_Click(object sender, MouseButtonEventArgs e)
        {
            Orders orders = new Orders();
            orders.ShowDialog();
        }

        private void Set_prices_Click(object sender, MouseButtonEventArgs e)
        {
            SetPrices setPrices = new SetPrices();
            setPrices.ShowDialog();
        }


    }
}
