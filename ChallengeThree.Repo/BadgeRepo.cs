using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree.Repo
{
    public class BadgeRepo
    {
        public Badge _badge = new Badge();
        public Dictionary<int, List<string>> badgedict = new Dictionary<int, List<string>>();

        public void CreateNewBadge(int badgeid, List<string> value)
        {
            var newBadgeID = new int();
            var newdoorlist = new List<string>();
            //badgedict.Add(newBadgeID, newdoorlist);
        }
        public Dictionary<int, List<string>> DisplayAllBadges()
        {
            return badgedict;
        }
        public List<string> doornames = new List<string>();
        public void AddDoorsToBadge()
        {
          _badge.DoorNames.AddRange(doornames);
        }

        public void DeleteDoorsFromBadge()
        {
            Badge badgetoRemove = new Badge();
            var doorsremove = new List<string>();
        }
        public Badge GetBadgeByID(int badgeid)
        {
            int id = new int();
            if (id == _badge.BadgeID)
            {
                return _badge;
            }

            else
            {
                return null;
            }
        }
    }
}
