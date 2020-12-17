using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.Repo
{
    public enum ClaimType
    {
        Car = 1,
        Home = 2,
        Theft = 3
    }
    public class Claim
    {
        
        public int ClaimID { get; set; }
        public ClaimType ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public Claim() { }
        public Claim(int claimid, ClaimType claimtype, string description, decimal claimamount, DateTime dateofincident, DateTime dateofclaim, bool isvalid)
        {
            ClaimID = claimid;
            ClaimType = claimtype;
            Description = description;
            ClaimAmount = claimamount;
            DateOfIncident = dateofincident;
            DateOfClaim = dateofclaim;
            IsValid = isvalid;
        }
    }
}
