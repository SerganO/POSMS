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
using System.Globalization;

namespace posms
{
    /// <summary>
    /// Interaction logic for SetPrices.xaml
    /// </summary>
    public partial class SetPrices : Window
    {
        List<AdminGood> adminGoods;
        public SetPrices()
        {
            InitializeComponent();
            adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods);

            additionalsGood = new List<AdminGood>();
            ListShopGoods.ItemsSource = new ObservableCollection<AdminGood>(adminGoods);
            if (ListShopGoods.Items.Count == 0)
            {
                Update_prices.IsEnabled = false;
                
            }
            ListShopGoods.IsReadOnly = true;
        }

        void Set_Read_status(bool b)
        {
            ListShopGoods.Columns[0].IsReadOnly = true;
            ListShopGoods.Columns[1].IsReadOnly = true;
            ListShopGoods.Columns[2].IsReadOnly = b;
            ListShopGoods.Columns[3].IsReadOnly = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        bool updating = false;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ListShopGoods.IsReadOnly = false;
            Set_Read_status(true);
            if (updating)
            {
                if (saveChange())
                {
                    updating = false;
                    Update_prices.Content = "Update";
                    CategoryProducts.IsEnabled = true;
                    Back_in_main_window.IsEnabled = true;
                    Search.IsEnabled = true;
                    ListShopGoods.IsReadOnly = false;
                    ListShopGoods.Columns[2].IsReadOnly = true;
                }
            }
            else
            {
                updating = true;
                Update_prices.Content = "End Update";
                CategoryProducts.IsEnabled = false;
                Back_in_main_window.IsEnabled = false;
                Search.IsEnabled = false;
                ListShopGoods.Columns[2].IsReadOnly = false;
            }
        }

        bool saveChange()
        {
            var result = MessageBox.Show("You want save change?", "Confirm change", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    saveChangeInBase();
                    updating = false;
                    updateUI();
                    return true;
                case MessageBoxResult.No:
                    updating = false;
                    updateUI();
                    return true;
                case MessageBoxResult.Cancel:
                    return false;

            }

            return false;
        }

        private void SetPrices_WindowClosing(object sender, ExitEventArgs e)
        {
            if (updating)
            {
               // e.Cancel = !saveChange();
            }
        }

        void saveChangeInBase()
        {
            int i = 0;
            foreach (var good in ListShopGoods.Items)
            {
               
                ListShopGoods.SelectedItem = ListShopGoods.Items[i];
                object item = ListShopGoods.SelectedItem;
                    ListShopGoods.ScrollIntoView(ListShopGoods.SelectedItem);
                try
                {
                    string ID = (ListShopGoods.SelectedCells[2].Column.GetCellContent(good) as TextBlock).Text;
                    adminGoods[i].Sell = double.Parse(ID, CultureInfo.InvariantCulture);
                }
                catch { }
                i++;
            }
            LoginManager.CurrentShop.Goods = new List<ShopGood>();
            foreach (AdminGood good in adminGoods)
            {
                LoginManager.CurrentShop.Goods.Add(good.getGood());
            }
            foreach (AdminGood good in additionalsGood)
            {
                LoginManager.CurrentShop.Goods.Add(good.getGood());
            }
            MainBase.Save();
           // ListShopGoods.SelectedItem = ListShopGoods.Items[0];
           // ListShopGoods.UpdateLayout();
            //ListShopGoods.ScrollIntoView(ListShopGoods.SelectedItem);
        }

        void updateUI()
        {
            bool c = ListShopGoods.Columns[2].IsReadOnly;
            Back_in_main_window.IsEnabled = !updating;
            Search.IsEnabled = !updating;
            CategoryProducts.IsEnabled = !updating;
            if (selectedCategory == 0)
            {
                adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods);
                ListShopGoods.ItemsSource = new ObservableCollection<AdminGood>(adminGoods);
            }
            else
            {
                adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods.Where(x => x.Category == (GoodCategory)(selectedCategory - 1)).ToList());
                ListShopGoods.ItemsSource = new ObservableCollection<AdminGood>(adminGoods);
            }
            ListShopGoods.Columns[0].IsReadOnly = true;
            ListShopGoods.Columns[1].IsReadOnly = true;
            ListShopGoods.Columns[2].IsReadOnly = c;
            ListShopGoods.Columns[3].IsReadOnly = true;
        }

        private void List_price_goods_DataError(object sender,DatePickerDateValidationErrorEventArgs e)
        {
            MessageBox.Show("Error with data! please check if the data is correct", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        List<AdminGood> additionalsGood;

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            selectedCategory = CategoryProducts.SelectedIndex;
            if (selectedCategory == 0)
            {
                adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods);
                additionalsGood = new List<AdminGood>();
                ListShopGoods.ItemsSource = new ObservableCollection<AdminGood>(adminGoods);
            }
            else
            {
                adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods.Where(x => x.Category == (GoodCategory)(selectedCategory - 1)).ToList());
                additionalsGood = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods.Where(x => x.Category != (GoodCategory)(selectedCategory - 1)).ToList());
                ListShopGoods.ItemsSource = new ObservableCollection<AdminGood>(adminGoods);
            }
        }
        int selectedCategory = 0;

        private void CategoryProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
