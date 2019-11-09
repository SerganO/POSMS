using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace posmsLite
{
    [Serializable]
    public enum GoodCategory {
        Milk, Bakery, HouseholdСhemicals, Meat, Fish, Cereals, Pasta, Fruit, Vegetables, Grocery
    }


    [Serializable]
    public class Good
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public GoodCategory Category { get; set; }
        private static string[] randName = { "Bread","Butter","Egg", "Water", "Sugar", "Salt", "Tea","Meat", "Chease", "Instant noodles", "Cake", "Toilet paper", "Soap", "Fish" };

        private static string[] randMilk = { "Milk", "Chease","Kefir", "Yogurt" }; 
        private static string[] randBakery = { "Bread", "Scone","Pita" };
        private static string[] randHouseholdСhemicals = { "Shower gel", "Powder", "Shampoo", "Pipe cleaner", "Soap" };
        private static string[] randMeat = {"Pork", "Beef", "Chicken", "Lamb" };
        private static string[] randFish = {"Salmon" , "Herring", "Hake", "Sturgeon", "Trout" };
        private static string[] randCereals = {"Cereals", "Oatmeal", "Buckwheat", "Perlovka", "Rice" };
        private static string[] randPasta = {"Instant noodles" };
        private static string[] randFruit = {"Apple", "Avocado", "Pineapple", "Orange", "Banana" };
        private static string[] randVegetables = {"Tomato", "Eggplant", "Broccoli", "Potato", "Corn", "Carrot" };
        private static string[] randGrocery = { "Salt", "Sugar", "Tea", "Cake" };


        public Good()
        {
            Name = "N/A";
            Count = 0;
        }
        public static Good randObject()
        {
            Good good = new Good();
            Random r = new Random();
            int n = 10;
            int k = r.Next() % n;

            Thread.Sleep(1);
            good.Category = (GoodCategory)k;
            string[] names;
            switch ((int)good.Category) {
                case 0:
                    names = Good.randMilk;
                    break;
                case 1:
                    names = Good.randBakery;
                    break;
                case 2:
                    names = Good.randHouseholdСhemicals;
                    break;
                case 3:
                    names = Good.randMeat;
                    break;
                case 4:
                    names = Good.randFish;
                    break;
                case 5:
                    names = Good.randCereals;
                    break;
                case 6:
                    names = Good.randPasta;
                    break;
                case 7:
                    names = Good.randFruit;
                    break;
                case 8:
                    names = Good.randVegetables;
                    break;
                case 9:
                    names = Good.randGrocery;
                    break;
                default:
                    names = Good.randMilk;
                    break;
            }

            good.Name = names[r.Next() % names.Length];
            good.Count = r.Next() % 201;
            Thread.Sleep(10);
            return good;
        }



        public override string ToString()
        {
            string res = "";

            res += "Name: " + Name + Environment.NewLine;
            res += "Count: " + Count + Environment.NewLine;

            return res;
        }

    }
}
