using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChallengeThree.Repo;

namespace ChallengeThree.Program
{
    class ProgramUI
    {
        public Badge _badge = new Badge();
        public BadgeRepo _badgeRepo = new BadgeRepo();
        public void Run()
        {
            BadgeMenu();
        }
        private void BadgeMenu()
        {
            var doornames = new List<string>();
            Console.WriteLine("Security Administrator: Choose a menu option:\n" +
                "1. Create a new badge.\n" +
                "2. Update doors on an existing badge.\n" +
                "3. Delete all doors from an existing badge.\n" +
                "4. Display all badges with badge number and door access.\n" +
                "5. Exit.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        CreateNewBadge();
                        break;
                    }
                case "2":
                    {
                        
                        AddDoorsToBadge(doornames);
                        break;
                    }
                case "3":
                    {
                        DeleteDoorsFromBadge();
                        break;
                    }
                case "4":
                    {
                        DisplayAllBadges();
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("Goodbye. Please press any key to continue...");
                        Console.ReadLine();
                        break;
                    }
            }
        }
        private void CreateNewBadge()
        {
            Console.WriteLine("What is the badge number?");
            string numstring = Console.ReadLine();
            int badgenum = Convert.ToInt32(numstring);
            Console.WriteLine("List a door this badge needs access to:");
            var doornames = new List<string>();
            var doornamestring = Console.ReadLine();
            doornames.Add(doornamestring);

            Console.WriteLine("Any other doors? y/n");
            string choice = Console.ReadLine();
            string lochoice = choice.ToLower();
            switch (lochoice)
            {
                case "y":
                    {
                        Console.WriteLine("List a door this badge needs access to:");
                        string doorname2 = Console.ReadLine();
                        doornames.Add(doorname2);
                        AddDoorsToBadge(doornames);
                        break;
                    }
                case "n":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please enter a valid response.");
                        break;
                    }
            }

        }
        private void AddDoorsToBadge(List<string> doornames)
        {

        }
        private void DeleteDoorsFromBadge()
        {
            
            int badgeid = new Int32();
            Badge badge = _badgeRepo.GetBadgeByID(badgeid);
            var doorarray = badge.DoorNames.ToArray();
            string door = doorarray.First();
            badge.DoorNames.Remove(door);
        }
        private void DisplayAllBadges()
        {

        }

    }
}
