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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace posms
{
    /// <summary>
    /// Interaction logic for PriceMonitoringWindow.xaml
    /// </summary>
    public partial class PriceMonitoringWindow : Window
    {
        List<MonitoringGood> goodsToShow = new List<MonitoringGood>();
        public PriceMonitoringWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        int regionIndex = -1;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {

               // var res = ((ComboBoxItem)(((ComboBox)sender).SelectedItem)).Content;
            Region checkedRegion = Converter.StringToRegion((res));
                List<Shop> regionsShops = MainBase.Shops.Where(x => x.Region == checkedRegion).ToList();
                string goodName = Good_name.Text;

                goodsToShow = new List<MonitoringGood>();
                foreach (Shop shop in regionsShops)
                {
                    foreach (ShopGood good in shop.Goods)
                    {
                        if (good.Name == goodName)
                        {
                            goodsToShow.Add(new MonitoringGood { ShopName = shop.Name, good = new GoodToShow(good.Name, good.Count, good.SellPrice, good.Category) });
                        }
                    }
                }

                ListShopGoods.ItemsSource = new ObservableCollection<MonitoringGood>(goodsToShow);

            }
            catch
            {

            }
        }

        string res = "";
        private void List_Region_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            res = (((ComboBoxItem)(((ComboBox)sender).SelectedItem)).Content).ToString();
            //regionIndex = List_Region.SelectedIndex;
        }
        bool check_sort = true;
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if(check_sort)
            {
                goodsToShow = (from u in goodsToShow
                               orderby u.Price descending
                               select u).ToList();
                ListShopGoods.ItemsSource = new ObservableCollection<MonitoringGood>(goodsToShow);
            }
            else
            {
                goodsToShow = (from u in goodsToShow
                               orderby u.Price
                               select u).ToList();
                ListShopGoods.ItemsSource = new ObservableCollection<MonitoringGood>(goodsToShow);
            }
            check_sort = !check_sort;
        }
    }
}
