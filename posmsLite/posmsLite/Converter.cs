using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posmsLite
{
    static class Converter
    {
        public static string RegionToString(Region region)
        {
            switch (region) {
                case Region.LT:return "Lutsk";
                case Region.LV:return "Lviv";
                case Region.UZ:return "Uzhhorod";
                case Region.RV:return "Rivne";
                case Region.TE:return "Ternopil";
                case Region.IF:return "Ivano-Frankivsk";
                case Region.CV:return "Chernivtsi";
                case Region.KM:return "Khmelnytskyi";
                case Region.ZT:return "Zhytomyr";
                case Region.VN:return "Vinnytsia";
                case Region.KV:return "Kyiv";
                case Region.CK:return "Cherkasy";
                case Region.KR:return "Kirovohrad";
                case Region.MK:return "Mykolaiv";
                case Region.OD:return "Odesa";
                case Region.CR:return "Crimea";
                case Region.KS:return "Kherson";
                case Region.DP:return "Dnipropetrovsk";
                case Region.PL:return "Poltava";
                case Region.CN:return "Chernihiv";
                case Region.SM:return "Sumy";
                case Region.KH:return "Kharkiv";
                case Region.DN:return "Donetsk";
                case Region.ZP:return "Zaporizhzhia";
                case Region.LG:return "Luhansk";
                default: return "N/A";

            }
        }

        public static Region StringToRegion(string regionString)
        {
            switch (regionString)
            {
                case "Lutsk": return Region.LT;
                case "Lviv": return Region.LV;
                case "Uzhhorod": return Region.UZ;
                case "Rivne": return Region.RV;
                case "Ternopil": return Region.TE;
                case "Ivano-Frankivsk": return Region.IF;
                case "Chernivtsi": return Region.CV;
                case "Khmelnytskyi": return Region.KM;
                case "Zhytomyr": return Region.ZT;
                case "Vinnytsia": return Region.VN;
                case "Kyiv": return Region.KV;
                case "Cherkasy": return Region.CK;
                case "Kropyvnytskyi": return Region.KR;
                case "Mykolaiv": return Region.MK;
                case "Odesa": return Region.OD;
                case "Crimea": return Region.CR;
                case "Kherson": return Region.KS;
                case "Dnipro": return Region.DP;
                case "Poltava": return Region.PL;
                case "Chernihiv": return Region.CN;
                case "Sumy": return Region.SM;
                case "Kharkiv": return Region.KH;
                case "Donetsk": return Region.DN;
                case "Zaporizhzhia": return Region.ZP;
                case "Luhansk": return Region.LG;
                default: throw new ArgumentException();

            }
        }

        public static List<GoodToShow> ShopGoodsToGoodsToShow(List<ShopGood> shopGoods)
        {
            List<GoodToShow> goods = new List<GoodToShow>();
            foreach(ShopGood good in shopGoods)
            {
                goods.Add(new GoodToShow(good.Name, good.Count, good.SellPrice));
            }

            return goods;
        }

        public static List<AdminGood> ShopGoodsToAdminGood(List<ShopGood> shopGoods)
        {
            List<AdminGood> goods = new List<AdminGood>();
            foreach (ShopGood good in shopGoods)
            {
                goods.Add(new AdminGood{Name = good.Name, Buy = good.BuyPrice, Sell = good.SellPrice, count = good.Count});
            }

            return goods;
        }

        public static List<GoodToShow> ProviderGoodsToGoodsToShow(List<ProviderGood> providerGoods)
        {
            List<GoodToShow> goods = new List<GoodToShow>();
            foreach (ProviderGood good in providerGoods)
            {
                goods.Add(new GoodToShow(good.Name, good.Count, good.SellPrice));
            }

            return goods;
        }
    }
}
