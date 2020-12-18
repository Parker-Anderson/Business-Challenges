using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChallengeOne.Repo;
using System.Collections.Generic;

namespace ChallengeOne.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private List<Menu.Item> _listofItems = new List<Menu.Item>();
        [TestMethod]
        public void Test_AddItem()
        {
            var menurepo = new MenuRepo();
            Menu.Item item = new Menu.Item();
            menurepo.AddItem(item);
            var addList = menurepo.GetItemList();
            var addcount = addList.Count;
            var listcount = _listofItems.Count;
            Assert.AreNotEqual(listcount, addList);
        }

        public void Test_GetItemList()
        {
            var menurepo = new MenuRepo();
            var testlist = menurepo.GetItemList();
            Assert.IsNotNull(testlist);
        }

        public void Test_RemoveItem()
        {
            var initialcount = _listofItems.Count;
            var menurepo = new MenuRepo();
            var item = new Menu.Item();
            menurepo.RemoveItem(item.MealNumber);
            Assert.AreNotEqual(initialcount, _listofItems.Count);
        }

        public void Test_GetItemByMealNumber()
        {
            var menurepo = new MenuRepo();
            var item = new Menu.Item();
            int mealnumber = item.MealNumber;
            menurepo.GetMealByNumber(mealnumber);
            Assert.IsNotNull(item);
        }
    }
}
