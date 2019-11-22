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
    /// Interaction logic for OrderGoods.xaml
    /// </summary>
    public partial class OrderGoods : Window
    {
        Order order = new Order();
        public OrderGoods()
        {
            InitializeComponent();
            List<ProviderGood> orderedGoods = order.goods;
            ListOrderGoods.ItemsSource = new ObservableCollection<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
            //ListOrderGoods.Columns[0].IsReadOnly = true;
            //ListOrderGoods.Columns[1].IsReadOnly = true;
            //ListOrderGoods.Columns[2].IsReadOnly = true;
            //ListOrderGoods.Columns[3].IsReadOnly = true;
            Change_quantity_good.IsEnabled = false;
            Delete_good.IsEnabled = false;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddToOrder addToOrder = new AddToOrder(order);
            if (addToOrder.ShowDialog() == true)
            {
                List<ProviderGood> orderedGoods = order.goods;
                ListOrderGoods.ItemsSource = new ObservableCollection<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
                Price_all_goods.Text = order.SummPrice.ToString();
                Change_quantity_good.IsEnabled = true;
                Delete_good.IsEnabled = true;
            }
            Set_Read_status(true);
        }
        List<ProviderGood> reserveData = new List<ProviderGood>();

        void Set_Read_status(bool b)
        {
            ListOrderGoods.Columns[0].IsReadOnly = true;
            ListOrderGoods.Columns[1].IsReadOnly = b;
            ListOrderGoods.Columns[2].IsReadOnly = true;
            ListOrderGoods.Columns[3].IsReadOnly = true;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool test = true;
                ListOrderGoods.Columns[1].IsReadOnly = !ListOrderGoods.Columns[1].IsReadOnly;
            test = ListOrderGoods.Columns[1].IsReadOnly;
            if (ListOrderGoods.Columns[1].IsReadOnly)
            {
                var result = MessageBox.Show("Confirm changes?", "Confirm", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        int i = 0;
                        foreach (ProviderGood good in order.goods)
                        {
                            ListOrderGoods.SelectedItem = ListOrderGoods.Items[i];
                            object item = ListOrderGoods.SelectedItem;
                            string ID = (ListOrderGoods.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                            good.Count = Convert.ToInt32(ID);
                            i++;
                        }
                       // Change_quantity_good.Content = MaterialDesignThemes.Wpf.PackIcon.Ima;
                        Delete_good.IsEnabled = true;
                        Add_good.IsEnabled = true;
                        break;
                    case MessageBoxResult.No:
                        order.goods = reserveData;
                        //Change_quantity_good.Content = "Change";
                        Delete_good.IsEnabled = true;
                        Add_good.IsEnabled = true;
                        break;
                    case MessageBoxResult.Cancel:
                        test = !test;
                        ListOrderGoods.Columns[1].IsReadOnly = !ListOrderGoods.Columns[1].IsReadOnly;
                        Change_quantity_good.IsChecked = !Change_quantity_good.IsChecked;

                        break;
                }
                List<ProviderGood> orderedGoods = order.goods;
                ListOrderGoods.ItemsSource = new ObservableCollection<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
                Price_all_goods.Text = order.SummPrice.ToString();
            }
            else
            {
               // Change_quantity_good.Content = "End Update";
                Delete_good.IsEnabled = false;
                Add_good.IsEnabled = false;
                reserveData = new List<ProviderGood>();
                foreach (ProviderGood good in order.goods)
                {
                    reserveData.Add(new ProviderGood(good.Name, good.Count, good.SellPrice));
                }
            }
            Set_Read_status(test);
        }
        
        private void Delete_good_Click(object sender, RoutedEventArgs e)
        {
           
            var result = MessageBox.Show("You are sure what you want delete selected rows?", "Confirm", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    foreach (var row in ListOrderGoods.SelectedItems)
                    {
                        int i = ListOrderGoods.Items.IndexOf(row);

                        order.goods.Remove(order.goods[i]);
                       // ListOrderGoods.Items.Remove(row);
                    }
                    List<ProviderGood> orderedGoods = order.goods;
                    ListOrderGoods.ItemsSource = new ObservableCollection<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
                    Price_all_goods.Text = order.SummPrice.ToString();
                    break;
            }

            if (ListOrderGoods.ItemsSource==null || ListOrderGoods.Items.Count==0)
            {
                Change_quantity_good.IsEnabled = false;
                Delete_good.IsEnabled = false;
            }
            Set_Read_status(true);

        }
        bool exitWithoutConfirm = false;

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Confirm order?", "Confirm", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    LoginManager.CurrentShop.Orders.Add(order);
                    MainBase.Save();
                    exitWithoutConfirm = true;
                    Close();
                    break;
                case MessageBoxResult.No:
                    exitWithoutConfirm = true;
                    Close();
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }
        }

        private void OrderGoods_FormClosing(object sender, ExitEventArgs e)
        {
            if (!exitWithoutConfirm)
            {
                var result = MessageBox.Show("You sure what you want go out, data not be saved?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.No:
                        break;
                }
            }
        }

        private void ListOrderGoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void List_order_goods_DataError(object sender, DataGridViewDataErrorEventArgs e)
        //{
        //    MessageBox.Show("Error with data! please check if the data is correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //private void List_order_goods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    order.goods[e.RowIndex].Count = Convert.ToInt32(List_order_goods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        //    //Price_all_goods.Text = order.SummPrice.ToString();
        //}
    }
}
