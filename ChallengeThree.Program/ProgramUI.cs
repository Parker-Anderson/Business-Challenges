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
        public List<Badge> _badgelist = new List<Badge>();       
        public void Run()
        {
            SeedBadges();
            BadgeMenu();
        }
        private void BadgeMenu()
        {
            bool keeprunning = true;
            while (keeprunning)
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
                            keeprunning = false;
                            break;
                        }
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
            badgenum = _badge.BadgeID;
            doornames = _badgeRepo.doornames;
            Console.WriteLine("Any other doors? y/n");
            string choice = Console.ReadLine();
            string lchoice = choice.ToLower();
            switch (lchoice)
            {
                case "y":
                    {
                        CreateNewBadge();
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
        public Badge badge = new Badge();
        private void AddDoorsToBadge(List<string> doornames)
        {
            Console.WriteLine("Badge ID Number: ");
            int badgeid = Convert.ToInt32(Console.ReadLine());
            badge = _badgeRepo.GetBadgeByID(badgeid);
            Console.WriteLine("What door should Badge have access to?");
            string doorname = Console.ReadLine();
            doornames.Add(doorname);
            // badge.DoorNames.Add(doorname);
            doornames = badge.DoorNames;
            Console.WriteLine("Do you want to add another door? y/n");
            string choice = Console.ReadLine();
            string lchoice = choice.ToLower();
            if (lchoice == "y")
            {
                AddDoorsToBadge(doornames);
            }
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
            foreach (Badge badge in _badgelist)
            {
                Console.WriteLine($"Badge ID: {badge.BadgeID}\n" +
                    $"Door Access: {badge.DoorNames}");
                Console.ReadLine();
            }
        }
        private void SeedBadges()
        {
            List<string> Doors1 = new List<string>();
            Doors1.Add("A7");
            List<string> Doors2 = new List<string>();
            Doors2.Add("A1");
            Doors2.Add("A4");
            Doors2.Add("B1");
            Doors2.Add("B2");
            List<string> Doors3 = new List<string>();
            Doors3.Add("A4");
            Doors3.Add("A5");
            Badge badge1 = new Badge(12345, Doors1);
            Badge badge2 = new Badge(22345, Doors2);
            Badge badge3 = new Badge(32345, Doors3);
            _badgeRepo.CreateNewBadge(badge1.BadgeID, badge1.DoorNames);
            _badgeRepo.CreateNewBadge(badge2.BadgeID, badge2.DoorNames);
            _badgeRepo.CreateNewBadge(badge3.BadgeID, badge3.DoorNames);
        }
    }
}
