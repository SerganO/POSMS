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
    public partial class AddToOrder : Form
    {
        Order Order;
        ProviderGood currentGood;
        public AddToOrder(Order parentOrder)
        {
            InitializeComponent();
            Order = parentOrder;
            foreach(Provider provider in LoginManager.CurrentShop.Providers)
            {
                providerBox.Items.Add(provider.Name);
            }

            

        }

        private void Back_in_order_goods_window_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Confirm_Click(object sender, EventArgs e)
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
                if(countTextBox.Text == "")
                {
                    throw new ArgumentException("Please set count");
                }
                count = Convert.ToInt32(countTextBox.Text);
                good.Count = count;
                var result = MessageBox.Show("Add " + good.StringForOrderList() + "Count: " + good.Count + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        Order.goods.Add(good);
                        DialogResult = DialogResult.OK;
                        MainBase.Save();
                        Close();
                        break;
                }
                
                
            } catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void providerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProviderGood> orderedGoods = LoginManager.CurrentShop.Providers[providerBox.SelectedIndex].Goods;
            var bindingList = new BindingList<String>();
            foreach(ProviderGood good in orderedGoods)
            {
                bindingList.Add(good.StringForOrderList());
            }
            var source = new BindingSource(bindingList, null);
            List_goods.DataSource = source;
        }

        private void List_goods_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentGood = LoginManager.CurrentShop.Providers[providerBox.SelectedIndex].Goods[List_goods.SelectedIndex];
        }
    }
}
