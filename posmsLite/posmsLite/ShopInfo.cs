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
    public partial class ShopInfo : Form
    {
        Shop shopToShow;
        public ShopInfo(Shop shop)
        {
            InitializeComponent();
            shopToShow = shop;
            if (shopToShow != null)
            {
                Shop_name_label.Text = shopToShow.Name;
                Shop_region_info_label.Text = Converter.RegionToString(shopToShow.Region);
              
                var bindingList = new BindingList<GoodToShow>(Converter.ShopGoodsToGoodsToShow(shopToShow.Goods));
                var source = new BindingSource(bindingList, null);
                List_shop_goods.DataSource = source;
            }
        }

        private void Back_in_main_window_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
