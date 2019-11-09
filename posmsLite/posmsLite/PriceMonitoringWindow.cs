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
    public partial class PriceMonitoringWindow : Form
    {
        List<MonitoringGood> goodsToShow = new List<MonitoringGood>();
        public PriceMonitoringWindow()
        {
            InitializeComponent();
        }

        private void Search_in_database_Click(object sender, EventArgs e)
        {
            try
            {
                Region checkedRegion = Converter.StringToRegion((List_region.Items[regionIndex].ToString()));
                List<Shop> regionsShops = MainBase.Shops.Where(x => x.Region == checkedRegion).ToList();
                string goodName = goodTextBox.Text;

                goodsToShow = new List<MonitoringGood>();
                foreach (Shop shop in regionsShops)
                {
                    foreach(ShopGood good in shop.Goods)
                    {
                        if(good.Name == goodName)
                        {
                            goodsToShow.Add(new MonitoringGood { ShopName = shop.Name, good = new GoodToShow(good.Name, good.Count, good.SellPrice, good.Category) });
                        }
                    }
                }

                var bindingList = new BindingList<MonitoringGood>(goodsToShow);
                var source = new BindingSource(bindingList, null);
                List_good_in_shops.DataSource = source;

            }
            catch
            {

            }
        }

        private void Back_in_main_window_Click(object sender, EventArgs e)
        {
            Close();
        }
        int regionIndex = -1;
        private void List_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            regionIndex = List_region.SelectedIndex;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            goodsToShow = (from u in goodsToShow
                                        orderby u.Price
                                        select u).ToList();
            var bindingList = new BindingList<MonitoringGood>(goodsToShow);
            var source = new BindingSource(bindingList, null);
            List_good_in_shops.DataSource = source;
        }

        private void sortByDescendingButton_Click(object sender, EventArgs e)
        {
            goodsToShow = (from u in goodsToShow
                           orderby u.Price descending
                           select u).ToList();
            var bindingList = new BindingList<MonitoringGood>(goodsToShow);
            var source = new BindingSource(bindingList, null);
            List_good_in_shops.DataSource = source;
        }
    }
}
