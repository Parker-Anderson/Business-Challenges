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
        public BadgeRepo _badgeRepo = new BadgeRepo();
        public void Run()
        {
            BadgeMenu();
        }
        private void BadgeMenu()
        {
            Console.WriteLine("Choose a menu option:\n" +
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
                        CreateBadge();
                        break;
                    }
                case "2":
                    {
                        break;
                    }
                case "3":
                    {
                        break;
                    }
                case "4":
                    {
                        break;
                    }
                case "5":
                    {
                        break;
                    }
            }
        }
        private void CreateBadge()
        {
            Console.WriteLine("What is the badge number?");
            string numstring = Console.ReadLine();
            int badgenum = Convert.ToInt32(numstring);
            Console.WriteLine("List a door this badge needs access to:");
            string doorname = Console.ReadLine();
            _badgeRepo._badge.BadgeID = badgenum;
            _badgeRepo.badgePairs.Add(badgenum, _badgeRepo._badge.DoorNames);
            _badgeRepo._badge.DoorNames.Add(doorname);
            Console.WriteLine("Any other doors? y/n");
            string choice = Console.ReadLine();
            string lochoice = choice.ToLower();
            switch (lochoice)
            {
                case "y":
                    {
                        Console.WriteLine("List a door this badge needs access to:");
                        string doorname2 = Console.ReadLine();
                        _badgeRepo._badge.BadgeID = badgenum;
                        _badgeRepo.badgePairs.Add(badgenum, _badgeRepo._badge.DoorNames);
                        _badgeRepo._badge.DoorNames.Add(doorname2);
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
    }
}
