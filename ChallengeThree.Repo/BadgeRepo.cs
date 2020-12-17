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
        public Dictionary<int, List<string>> badgePairs = new Dictionary<int, List<string>>() { };
        public Dictionary<int, Badge> badgedict = new Dictionary<int, Badge>();

        public void CreateNewBadge(int badgeid, Badge value)
        {
            var newBadgeID = new int();
            var newBadgeDoors = new List<string>();
            badgedict.Add(newBadgeID, value);
        }

        public Dictionary<int, Badge> DisplayAllPairs()
        {
            return badgedict;
        }

  
    }
}
