using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChallengeThree.Repo;
using System.Collections.Generic;

namespace ChallengeThree.Tests
{
    [TestClass]
    public class ChallengeThreeTest
    {
        private Badge _badge = new Badge();
        private BadgeRepo _badgerepo = new BadgeRepo();
        private Dictionary<int, List<string>> badgedict = new Dictionary<int, List<string>>();

        [TestMethod]
        public void Test_CreateNewBadge()
        {
            var badgeid = new int();
            var doorlist = new List<string>();
            badgeid = _badge.BadgeID;
            doorlist = _badge.DoorNames;
            badgedict.Add(badgeid, doorlist);
            var newdoorlist = new List<string>();
            Assert.AreNotEqual(doorlist.Count, newdoorlist.Count);
        }

        public void Test_DisplayAllBadges()
        {
            _badgerepo.DisplayAllBadges();
            Assert.IsNotNull(badgedict);
        }

        private void Test_DeleteDoorsFromBadge()
        {
            //
        }

        private void Test_GetBadgeByID()
        {
            int badgeid = new Int32();
            _badgerepo.GetBadgeByID(badgeid);
            Assert.AreEqual(_badge.BadgeID, badgeid);
        }
    }
}
