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
    public partial class Orders : Form
    {
        List<Order> currentOrders = new List<Order>();
        public Orders()
        {
            InitializeComponent();
            foreach(Order order in LoginManager.CurrentShop.Orders)
            {
                List_Orders.Items.Add(order.ID);
            }
            currentOrders = LoginManager.CurrentShop.Orders;
        }

        private void Back_in_main_window_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Confirm_delivery_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Are you sure you want confirm delivery?", "Agree", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    LoginManager.CurrentShop.Orders[List_Orders.SelectedIndex].status = true;
                    break;
            }
            MainBase.Save();
        }

        private void List_Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ProviderGood> orderedGoods = currentOrders[List_Orders.SelectedIndex].goods;
            var bindingList = new BindingList<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
            var source = new BindingSource(bindingList, null);
            List_goods_order.DataSource = source;
        }

        private void List_Orders_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            string text = ((ComboBox)sender).Items[e.Index].ToString();
  
            Brush brush;
            
            if (currentOrders[e.Index].status)
            {
                brush = Brushes.Green;
            }
            else
            {
                brush = Brushes.Orange;
            }
            e.Graphics.DrawString(text, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
        }

        private void OnlyNotDeliveredCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            while (List_Orders.Items.Count != 0)
            {
                List_Orders.Items.Remove(List_Orders.Items[0]);
            }
            currentOrders = new List<Order>();
            if (OnlyNotDeliveredCheckBox.Checked)
            {
                foreach (Order order in LoginManager.CurrentShop.Orders)
                {
                    if (!order.status)
                    {
                        currentOrders.Add(order);
                        List_Orders.Items.Add(order.ID);
                    }
                }
            } else
            {  
                foreach (Order order in LoginManager.CurrentShop.Orders)
                {
                    currentOrders.Add(order);
                    List_Orders.Items.Add(order.ID);
                }
            }
        }
    }
}
