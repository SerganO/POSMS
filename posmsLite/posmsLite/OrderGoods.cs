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
    public partial class OrderGoods : Form
    {
        Order order = new Order();
        public OrderGoods()
        {
            InitializeComponent();
            List<ProviderGood> orderedGoods = order.goods;
            var bindingList = new BindingList<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
            var source = new BindingSource(bindingList, null);
            List_order_goods.DataSource = source;
            List_order_goods.Columns["Name"].ReadOnly = true;
            List_order_goods.Columns["Price"].ReadOnly = true;
            List_order_goods.Columns["Count"].ReadOnly = true;
            List_order_goods.Update();
            
        }

        private void OrderGoods_Load(object sender, EventArgs e)
        {

        }

        private void Add_good_Click(object sender, EventArgs e)
        {
            AddToOrder addToOrder = new AddToOrder(order);
            if(addToOrder.ShowDialog() == DialogResult.OK)
            {
                List<ProviderGood> orderedGoods = order.goods;
                var bindingList = new BindingList<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
                var source = new BindingSource(bindingList, null);
                List_order_goods.DataSource = source;
                Price_all_goods.Text = order.SummPrice.ToString();
            }
        }
        List<ProviderGood> reserveData = new List<ProviderGood>();
        private void Change_quantity_good_Click(object sender, EventArgs e)
        {
            List_order_goods.Columns["Count"].ReadOnly = !List_order_goods.Columns["Count"].ReadOnly;
            if(List_order_goods.Columns["Count"].ReadOnly)
            {
                var result = MessageBox.Show("Confirm changes?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        Change_quantity_good.Text = "Change";
                        break;
                    case DialogResult.No:
                        order.goods = reserveData;
                        Change_quantity_good.Text = "Change";
                        break;
                    case DialogResult.Cancel:
                        List_order_goods.Columns["Count"].ReadOnly = !List_order_goods.Columns["Count"].ReadOnly;

                        break;
                }
                List<ProviderGood> orderedGoods = order.goods;
                var bindingList = new BindingList<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
                var source = new BindingSource(bindingList, null);
                List_order_goods.DataSource = source;
                Price_all_goods.Text = order.SummPrice.ToString();
            } else
            {
                Change_quantity_good.Text = "End Update";
                reserveData = new List<ProviderGood>();
                foreach(ProviderGood good in order.goods)
                {
                    reserveData.Add(new ProviderGood(good.Name, good.Count,good.SellPrice));
                }
            }
        }

        private void Delete_good_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You are sure what you want delete selected rows?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    foreach (DataGridViewRow row in List_order_goods.SelectedRows)
                    {
                        order.goods.Remove(order.goods[row.Index]);
                        List_order_goods.Rows.Remove(row);
                    }
                    List<ProviderGood> orderedGoods = order.goods;
                    var bindingList = new BindingList<GoodToShow>(Converter.ProviderGoodsToGoodsToShow(orderedGoods));
                    var source = new BindingSource(bindingList, null);
                    List_order_goods.DataSource = source;
                    Price_all_goods.Text = order.SummPrice.ToString();
                    break;
            }
            

        }
        bool exitWithoutConfirm = false;
        private void Confirm_order_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirm order?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    LoginManager.CurrentShop.Orders.Add(order);
                    MainBase.Save();
                    exitWithoutConfirm = true;
                    Close();
                    break;
                case DialogResult.No:
                    exitWithoutConfirm = true;
                    Close();
                    break;
                case DialogResult.Cancel:
                    break;
            }
            
        }

        private void Back_in_main_window_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void List_order_goods_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error with data! please check if the data is correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void List_order_goods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            order.goods[e.RowIndex].Count = Convert.ToInt32(List_order_goods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            //Price_all_goods.Text = order.SummPrice.ToString();
        }

        private void OrderGoods_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!exitWithoutConfirm)
            {
                var result = MessageBox.Show("You sure what you want go out, data not be saved?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
