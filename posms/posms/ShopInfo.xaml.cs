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
    /// Interaction logic for ShopInfo.xaml
    /// </summary>
    public partial class ShopInfo : Window
    {
        Shop shopToShow;
        public ShopInfo(Shop shop)
        {
            InitializeComponent();
            shopToShow = shop;
            if (shopToShow != null)
            {
                ShopName.Text = shopToShow.Name;
                ShopRegionInfo.Text = Converter.RegionToString(shopToShow.Region);

                
                ListShopGoods.ItemsSource= new ObservableCollection<GoodToShow>(Converter.ShopGoodsToGoodsToShow(shopToShow.Goods));
                // var bindingList = new <GoodToShow>(Converter.ShopGoodsToGoodsToShow(shopToShow.Goods));
                //var source = new BindingStatus(bindingList, null);
                //ListShopGoods.DataContext = source;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        int selectedCategory = 0;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (selectedCategory == 0)
            {
                if (shopToShow != null)
                { 
                    ListShopGoods.ItemsSource = new ObservableCollection<GoodToShow>(Converter.ShopGoodsToGoodsToShow(shopToShow.Goods));
                    //var bindingList = new < GoodToShow > (Converter.ShopGoodsToGoodsToShow(shopToShow.Goods));
                    //var source = new BindingSource(bindingList, null);
                    //ListShopGoods.DataContext = source;
                }
            }
            else
            {
                if (shopToShow != null)
                {
                    //var res = ((ComboBoxItem)(((ComboBox)sender).SelectedItem)).Content;
                    var goodsToShow = shopToShow.Goods.Where(x => x.Category == (GoodCategory)(selectedCategory-1)).ToList();
                    ListShopGoods.ItemsSource = new ObservableCollection<GoodToShow>(Converter.ShopGoodsToGoodsToShow(goodsToShow));
                    //var bindingList = new BindingList<GoodToShow>(Converter.ShopGoodsToGoodsToShow(goodsToShow));
                    //var source = new BindingSource(bindingList, null);
                    //ListShopGoods.DataContext = source;
                }
            }
        }

        private void CategoryProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedCategory = CategoryProducts.SelectedIndex;
        }
    }
}
