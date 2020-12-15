using ChallengeOne.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChallengeOne.Repo.Menu;

namespace Program
{
    class ProgramUI
    {
        private MenuRepo _menuRepo = new MenuRepo();
        public void Run()
        {
            SeedList();
            ManagerMenu();
        }
        private void ManagerMenu()
        {
            bool keepRunning = true;
            while (keepRunning)

            {
                System.Console.WriteLine("Choose a menu option:\n" +
                         "1. View Menu Options.\n" +
                         "2. Add a Meal Option.\n" +
                         "3. Remove a Meal Option from the Menu\n" +
                         "4. Exit.");
                string choice = System.Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ReadMenu();
                        break;
                    case "2":
                        AddItem();
                        break;
                    case "3":
                        RemoveItem();
                        break;
                    case "4":
                        System.Console.WriteLine("Goodbye");
                        System.Console.ReadKey();
                        keepRunning = false;
                        break;
                    default:
                        System.Console.WriteLine("Please enter a valid selection.");
                        break;
                }
                System.Console.WriteLine("Press any key to continue...");
                System.Console.ReadKey();
                System.Console.Clear();
            }
        }
        private void AddItem()
        {
            System.Console.Clear();
            var newmeal = new Menu.Item();

            System.Console.WriteLine("Enter the Meal Number: ");
            string mealnumstring = (System.Console.ReadLine());




            int mealnum = Convert.ToInt32(mealnumstring);
            newmeal.MealNumber = mealnum;

            System.Console.WriteLine("Enter the Meal Name: ");
            string mealname = System.Console.ReadLine();
            newmeal.MealName = mealname;

            System.Console.WriteLine("Enter a description for the new meal item: ");
            string mealdescription = System.Console.ReadLine();
            newmeal.Description = mealdescription;

            System.Console.WriteLine("Please write a list of the meal ingredients(separated by commas): ");
            string ingredients = System.Console.ReadLine();
            newmeal.ListOfIngredients = ingredients;

            System.Console.WriteLine("Enter the new meal price(as a decimal value(i.e. '1.99')): ");
            string mealpricestring = System.Console.ReadLine();
            decimal mealprice = Convert.ToDecimal(mealpricestring);
            newmeal.Price = mealprice;

            _menuRepo.AddItem(newmeal);
        }
        private void RemoveItem()
        {
            System.Console.Clear();
            ReadMenu();
            System.Console.WriteLine("\nEnter the meal number of the item you want to remove:");
            int input = Convert.ToInt32(System.Console.ReadLine());
            bool removeItem = _menuRepo.RemoveItem(input);
            if (removeItem)
            {
                System.Console.WriteLine("Item was successfully removed.");
            }
            else
            {
                System.Console.WriteLine("Item could not be removed.");
            }
        }
        private void ReadMenu()
        {
            System.Console.Clear();
            List<Menu.Item> listofItems = _menuRepo.GetItemList();
            foreach (Menu.Item item in listofItems)
            {
                System.Console.WriteLine($"Meal Number: {item.MealNumber}\n" +
                    $"Meal Name: {item.MealName}\n" +
                    $"Description: {item.Description}\n" +
                    $"Ingredients: {item.ListOfIngredients}\n" +
                    $"Price: {item.Price}");
            }
        }
        private void SeedList()
        {
            Item hamburger = new Item(1, "Hamburger", "Grilled beef patty on a bun.", "Beef, Salt, Pepper, Bun", 6.99M);
            Item hotdog = new Item(2, "Hot Dog", "Grilled Frankfurter on a bun.", "Beef(various parts of cow), Seasonings, Bun", 4.99M);
            _menuRepo.AddItem(hamburger);
            _menuRepo.AddItem(hotdog);
        }
    }
}
