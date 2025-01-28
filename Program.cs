using System;
using System.Collections.Generic;

namespace GearTrackerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GearItem> gearList = new List<GearItem>();

            while (true)
            {
                Console.WriteLine("\n--- Gear Tracker ---");
                Console.WriteLine("1. Add Gear");
                Console.WriteLine("2. View Gear");
                Console.WriteLine("3. Remove Gear");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddGear(gearList);
                        break;
                    case "2":
                        ViewGear(gearList);
                        break;
                    case "3":
                        RemoveGear(gearList);
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddGear(List<GearItem> gearList)
        {
            Console.Write("Enter gear name: ");
            string name = Console.ReadLine();

            Console.Write("Enter gear type (e.g., jacket, shoes): ");
            string type = Console.ReadLine();

            Console.Write("Enter gear condition (e.g., new, used): ");
            string condition = Console.ReadLine();

            GearItem gear = new GearItem(name, type, condition);
            gearList.Add(gear);

            Console.WriteLine("Gear added successfully!");
        }

        static void ViewGear(List<GearItem> gearList)
        {
            if (gearList.Count == 0)
            {
                Console.WriteLine("No gear in the tracker.");
                return;
            }

            Console.WriteLine("\n--- Gear List ---");
            for (int i = 0; i < gearList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {gearList[i]}");
            }
        }

        static void RemoveGear(List<GearItem> gearList)
        {
            if (gearList.Count == 0)
            {
                Console.WriteLine("No gear to remove.");
                return;
            }

            Console.WriteLine("\n--- Gear List ---");
            for (int i = 0; i < gearList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {gearList[i]}");
            }

            Console.Write("Enter the number of the gear to remove: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= gearList.Count)
            {
                gearList.RemoveAt(index - 1);
                Console.WriteLine("Gear removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid input. No gear removed.");
            }
        }
    }
}
