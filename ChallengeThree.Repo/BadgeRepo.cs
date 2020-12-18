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
        public Dictionary<int, Badge> badgedict = new Dictionary<int, Badge>();

        public void CreateNewBadge(int badgeid, Badge value)
        {
            var newBadgeID = new int();
            var newBadge = new Badge();
            badgedict.Add(newBadgeID, newBadge);
        }

        public Dictionary<int, Badge> DisplayAllPairs()
        {
            return badgedict;
        }
        public List<string> doornames = new List<string>();
        public void AddDoorsToNewBadge()
        {
          _badge.DoorNames.AddRange(doornames);
        }

  
    }
}
