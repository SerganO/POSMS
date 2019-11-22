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
    /// Interaction logic for AddToOrder.xaml
    /// </summary>
    public partial class AddToOrder : Window
    {
        Order Order;
        ProviderGood currentGood;
        public AddToOrder(Order parentOrder)
        {
            InitializeComponent();
            Order = parentOrder;
            foreach (Provider provider in LoginManager.CurrentShop.Providers)
            {
                Provider_list.Items.Add(provider.Name);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProviderGood good = new ProviderGood();
            try
            {
                good = currentGood;
                if (currentGood == null)
                {
                    throw new ArgumentException("Good are not selected");
                }
                int count;
                if (Count_good.Text == "")
                {
                    throw new ArgumentException("Please set count");
                }
                count = Convert.ToInt32(Count_good.Text);
                good.Count = count;
                var result = MessageBox.Show("Add " + good.StringForOrderList() + "Count: " + good.Count + "?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        Order.goods.Add(good);
                        DialogResult = true;
                        MainBase.Save();
                        Close();
                        break;
                }


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Provider_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<ProviderGood> orderedGoods = LoginManager.CurrentShop.Providers[Provider_list.SelectedIndex].Goods;
            var bindingList = new ObservableCollection<String>();
            foreach (ProviderGood good in orderedGoods)
            {
                bindingList.Add(good.StringForOrderList());
            }
            Good_list.ItemsSource = bindingList;
        }

        private void Good_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentGood = LoginManager.CurrentShop.Providers[Provider_list.SelectedIndex].Goods[Good_list.SelectedIndex];
        }
    }
}
