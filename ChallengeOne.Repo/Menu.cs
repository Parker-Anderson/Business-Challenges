using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.Repo
{
    public class Menu
    {
        public class Item
        {
            public int MealNumber { get; set; }
            public string MealName { get; set; }
            public string Description { get; set; }
            public string ListOfIngredients { get; set; }
            public decimal Price { get; set; }

            public Item() { }
            public Item(int mealnumber, string mealname, string description, string listofingredients, decimal price)
            {
                MealNumber = mealnumber;
                MealName = mealname;
                Description = description;
                ListOfIngredients = listofingredients;
                Price = price;
            }
        }
    }
}
