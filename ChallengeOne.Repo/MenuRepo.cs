using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.Repo
{
    public class MenuRepo
    {
        private List<Menu.Item> _listofItems = new List<Menu.Item>();
        public void AddItem(Menu.Item newitem)
        {
            _listofItems.Add(newitem);
        }
        public List<Menu.Item> GetItemList()
        {
            return _listofItems;
        }
        public bool RemoveItem(int mealnum)
        {
            Menu.Item item = GetMealByNumber(mealnum);
            if (item == null)
            {
                return false;
            }
            int initialCount = _listofItems.Count;
            _listofItems.Remove(item);
            if (initialCount > _listofItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Menu.Item GetMealByNumber(int mealnumber)
        {
            foreach (Menu.Item item in _listofItems)
            {
                if (item.MealNumber == mealnumber)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
