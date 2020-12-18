using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ChallengeTwo.Repo
{
    public class ClaimRepo
    {
        private Queue<Claim> _claims = new Queue<Claim>();
        public Queue<Claim> SeeAllClaims()
        {
            return _claims;
        }
        public void WorkNextClaim()
        {
            _claims.Dequeue();
        }
        public void CreateClaim(Claim claim1)
        {
            var newclaim = new Claim();
            _claims.Enqueue(newclaim);
        }
    }
}
