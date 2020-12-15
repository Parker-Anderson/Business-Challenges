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
    }
}
