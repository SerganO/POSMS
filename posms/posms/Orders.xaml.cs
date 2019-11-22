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
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Orders : Window
    {
        List<Order> currentOrders = new List<Order>();
        public Orders()
        {
            InitializeComponent();
            foreach (Order order in LoginManager.CurrentShop.Orders)
            {
                Orders_list.Items.Add(order.ID);
            }
            currentOrders = LoginManager.CurrentShop.Orders;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (currentOrders[Orders_list.SelectedIndex].status)
            {
                MessageBox.Show("Order already confirm!");
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want confirm delivery?", "Agree", MessageBoxButton.YesNo, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        currentOrders[Orders_list.SelectedIndex].status = true;
                        foreach (ProviderGood good in currentOrders[Orders_list.SelectedIndex].goods)
                        {
                            ShopGood shopGood = LoginManager.CurrentShop.Goods.Find(x => x.equalWithProviderGood(good));
                            if (shopGood != null)
                            {
                                shopGood.Count += good.Count;
                            }
                            else
                            {
                                LoginManager.CurrentShop.AddProviderGoodToGoods(good);
                            }
                        }
                        break;
                }
                MainBase.Save();
            }
        }

        private void Orders_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = Orders_list.SelectedIndex;
            if (index >= 0)
            {
                List<ProviderGood> orderedGoods = currentOrders[index].goods;
                ListOrders.ItemsSource = new ObservableCollection<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
            }
        }

       
        //private void List_Orders_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    e.DrawBackground();
        //    string text = ((ComboBox)sender).Items[e.Index].ToString();

        //    Brush brush;

        //    if (currentOrders[e.Index].status)
        //    {
        //        brush = Brushes.Green;
        //    }
        //    else
        //    {
        //        brush = Brushes.Orange;
        //    }
        //    e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        //}

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            ListOrders.ItemsSource = null;
            while (Orders_list.Items.Count != 0)
            {
                Orders_list.Items.Remove(Orders_list.Items[0]);
            }
            currentOrders = new List<Order>();
            if (Only_not_delivered_checked.IsChecked==true)
            {
                foreach (Order order in LoginManager.CurrentShop.Orders)
                {
                    if (!order.status)
                    {
                        currentOrders.Add(order);
                        Orders_list.Items.Add(order.ID);
                    }
                }
            }
            else
            {
                foreach (Order order in LoginManager.CurrentShop.Orders)
                {
                        currentOrders.Add(order);
                        Orders_list.Items.Add(order.ID);
                }
            }
        }
    }
}
