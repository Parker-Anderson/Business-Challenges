using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ChallengeTwo.Repo;
using System.Collections.Generic;

namespace ChallengeTwo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Queue<Claim> _claims = new Queue<Claim>();
        [TestMethod]
        public void Test_SeeAllClaims()
        {
            var claimrepo = new ClaimRepo();
            claimrepo.SeeAllClaims();
            Assert.IsNotNull(_claims);
        }
        public void Test_WorkNextClaim()
        {
            var claimrepo = new ClaimRepo();
            var initialclaims = _claims.Count;
            claimrepo.WorkNextClaim();
            Assert.AreNotEqual(initialclaims, _claims.Count);
        }
        public void Test_CreateClaim()
        {
            var claimrepo = new ClaimRepo();
            var initialcount = _claims.Count;
            var testclaim = new Claim();
            claimrepo.CreateClaim(testclaim);
            int newcount = _claims.Count;
            Assert.AreNotEqual(initialcount, newcount);
        }
    }
}
