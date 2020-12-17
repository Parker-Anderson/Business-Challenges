using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeTwo.Repo;

namespace ChallengeTwo.Program
{
    class ProgramUI
    {
        private ClaimRepo _claimRepo = new Repo.ClaimRepo();
        private Claim _claim = new Claim();
        private Queue<Claim> _claims = new Queue<Claim>();
        public void Run()
        {
            SeedQueue();
            ClaimMenu();
        }
        private void ClaimMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Choose a menu option:\n" +
                    "1. See all claims.\n" +
                    "2. Next claim.\n" +
                    "3. Enter a new claim.\n" +
                    "4. Exit.");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            SeeAllClaims();
                            Console.ReadKey();
                            break;
                        }
                    case "2":
                        {
                            WorkNextClaim();
                            break;
                        }
                    case "3":
                        {
                            CreateClaim();
                            break;
                        }
                    case "4":
                        {
                            keepRunning = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Please enter a valid selection.");
                        break;
                }
                Console.Clear();
            }
        }
            private void SeeAllClaims()
        {
            Console.Clear();
            foreach (Claim claim in _claims)
            {
                Console.WriteLine($"Claim ID: {claim.ClaimID}\n" +
                    $"Claim Type: {(int)claim.ClaimType}\n" +
                    $"Description: {claim.Description}\n" +
                    $"Amount: {claim.ClaimAmount}\n" +
                    $"Date of Incident: {claim.DateOfIncident}\n" +
                    $"Date of Claim: {claim.DateOfClaim}\n" +
                    $"IsValid: {claim.IsValid}");
            }
         }
            private void WorkNextClaim()
        {
            Claim nextClaim = _claims.Peek();
            Console.Clear();
            Console.WriteLine($"Claim ID: {nextClaim.ClaimID}\n" +
                    $"Claim Type: {nextClaim.ClaimType}\n" +
                    $"Description: {nextClaim.Description}\n" +
                    $"Amount: {nextClaim.ClaimAmount}\n" +
                    $"Date of Incident: {nextClaim.DateOfIncident}\n" +
                    $"Date of Claim: {nextClaim.DateOfClaim}\n" +
                    $"IsValid: {nextClaim.IsValid}");
            Console.WriteLine("Do you want to take care of this claim? y/n");
            string choice = Console.ReadLine();
            string input = choice.ToLower();
            switch (input)
            {
                case "y":
                    {
                        _claims.Dequeue();
                        break;
                    }
                case "n":
                    {
                        break;
                    }
            }
    }
            private void CreateClaim()
            {
            Console.Clear();
            var newClaim = new Claim();
            Console.WriteLine("Enter the Claim ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            newClaim.ClaimID = id;
            Console.WriteLine("Enter the Claim Type:(1 for Car, 2 for Home, 3 for Theft)");
            int type = Convert.ToInt32(Console.ReadLine());
            newClaim.ClaimType = (ClaimType)type;
            Console.WriteLine("Enter a description of the accident:");
            string description = Console.ReadLine();
            newClaim.Description = description;
            Console.WriteLine("Enter the dollar amount of the Claim:");
            string stringamount = Console.ReadLine();
            decimal amount = Convert.ToDecimal(stringamount);
            newClaim.ClaimAmount = amount;
            Console.WriteLine("Enter the date of the accident:");
            string accidentdate = Console.ReadLine();
            DateTime accdate = Convert.ToDateTime(accidentdate);
            newClaim.DateOfIncident = accdate;
            Console.WriteLine("Enter the Date of the Claim:");
            string claimdatestring = Console.ReadLine();
            DateTime claimdate = Convert.ToDateTime(claimdatestring);
            newClaim.DateOfClaim = claimdate;
            TimeSpan validcheck = claimdate - accdate;
            if (validcheck.TotalDays > 30)
            {
                newClaim.IsValid = false;
            }
            else
            {
                newClaim.IsValid = true;
            }
            _claims.Enqueue(newClaim);
            }
            private void SeedQueue()
            {
            Claim claim1 = new Claim(1, ClaimType.Car, "Car Accident on 465", 378.00m, DateTime.Parse("04/25/2018"), DateTime.Parse("04/27/2018"), true);
            Claim claim2 = new Claim(2, ClaimType.Home, "House Fire in Kitchen", 23344.12m, DateTime.Parse("04/11/2018"), DateTime.Parse("04/12/2018"), true);
            Claim claim3 = new Claim(3, ClaimType.Theft, "Stolen Pancakes", 4.00m, DateTime.Parse("04/27/2018"), DateTime.Parse("06/01/2018"), false);
            _claimRepo.CreateClaim(claim1);
            _claimRepo.CreateClaim(claim2);
            _claims.Enqueue(claim1);
            _claims.Enqueue(claim2);
            _claims.Enqueue(claim3);
            }
    }
}
