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
    public partial class SetPrices : Form
    {
        List<AdminGood> adminGoods;
        public SetPrices()
        {
            InitializeComponent();
            adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods);

            additionalsGood = new List<AdminGood>();
            var bindingList = new BindingList<AdminGood>(adminGoods);
            var source = new BindingSource(bindingList, null);
            List_price_goods.DataSource = source;
            List_price_goods.Columns["Sell"].ReadOnly = true;
            List_price_goods.Columns["Buy"].ReadOnly = true;
            List_price_goods.Columns["Name"].ReadOnly = true;
            List_price_goods.Columns["Category"].ReadOnly = true;
        }
        bool updating = false;
        private void Update_prices_Click(object sender, EventArgs e)
        {
            if(updating)
            {
                if(saveChange())
                {
                    updating = false;
                    Update_prices.Text = "Update";
                    categoryComboBox.Enabled = true;
                    Back_in_main_window.Enabled = true;
                    searchButton.Enabled = true;
                    List_price_goods.Columns["Sell"].ReadOnly = true;
                }
            } else
            {
                updating = true;
                Update_prices.Text = "End Update";
                categoryComboBox.Enabled = false;
                Back_in_main_window.Enabled = false;
                searchButton.Enabled = false;
                List_price_goods.Columns["Sell"].ReadOnly = false;
            }
        }

        private void Back_in_main_window_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool saveChange()
        {
            var result = MessageBox.Show("You want save change?","Confirm change", MessageBoxButtons.YesNoCancel);
            switch (result) {
                case DialogResult.Yes:
                    saveChangeInBase();
                    updating = false;
                    updateUI();
                    return true;
                case DialogResult.No:
                    updating = false;
                    updateUI();
                    return true;
                case DialogResult.Cancel:
                    return false;

            }

            return false;
        }
        private void SetPrices_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(updating)
            {
                e.Cancel = !saveChange();
            }
        }

        void saveChangeInBase()
        {
            LoginManager.CurrentShop.Goods = new List<ShopGood>();
            foreach(AdminGood good in adminGoods)
            {
                LoginManager.CurrentShop.Goods.Add(good.getGood());
            }
            foreach (AdminGood good in additionalsGood)
            {
                LoginManager.CurrentShop.Goods.Add(good.getGood());
            }
            MainBase.Save();
        }

        void updateUI()
        {
            Back_in_main_window.Enabled = !updating;
            searchButton.Enabled = !updating;
            categoryComboBox.Enabled = !updating;
            if(selectedCategory == 0)
            {
                adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods);
                var bindingList = new BindingList<AdminGood>(adminGoods);
                var source = new BindingSource(bindingList, null);
                List_price_goods.DataSource = source;
            } else
            {
                adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods.Where(x => x.Category == (GoodCategory)(selectedCategory - 1)).ToList());
                var bindingList = new BindingList<AdminGood>(adminGoods);
                var source = new BindingSource(bindingList, null);
                List_price_goods.DataSource = source;
            }
        }

        private void List_price_goods_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error with data! please check if the data is correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        List<AdminGood> additionalsGood;
        private void searchButton_Click(object sender, EventArgs e)
        {
            selectedCategory = categoryComboBox.SelectedIndex;
            if (selectedCategory == 0)
            {
                adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods);
                additionalsGood = new List<AdminGood>();
                var bindingList = new BindingList<AdminGood>(adminGoods);
                var source = new BindingSource(bindingList, null);
                List_price_goods.DataSource = source;
            } else
            {
                adminGoods = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods.Where(x => x.Category == (GoodCategory)(selectedCategory - 1)).ToList());
                additionalsGood = Converter.ShopGoodsToAdminGood(LoginManager.CurrentShop.Goods.Where(x => x.Category != (GoodCategory)(selectedCategory - 1)).ToList());
                var bindingList = new BindingList<AdminGood>(adminGoods);
                var source = new BindingSource(bindingList, null);
                List_price_goods.DataSource = source;
            }
        }
        int selectedCategory = 0;
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
