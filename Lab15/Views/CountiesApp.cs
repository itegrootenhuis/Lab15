using System;
using System.Collections.Generic;
using Controllers;

namespace Views
{
    public class CountiesApp
    {
        public static void AppInit()
        {
            Welcome();
            NavigateConsoleApp();
        }

        internal static void Welcome()
        {
            Console.WriteLine("Welcome to the Countries App!");
        }

        private static void NavigateConsoleApp()
        {
            Console.WriteLine("\nPress A to see a list of the counties.");
            Console.WriteLine("Press B add a country to the list.");
            Console.WriteLine("Press any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "a")
            {
                Console.Clear();
                PrintCountyList(CountiesController.GetCountryList());
            }
            else if (quitKey.Key.ToString().ToLower() == "b")
            {
                Console.Clear();
                AddCountryToList();
            }
        }

        private static void PrintCountyList(List<string> countryList)
        {
            foreach (string country in countryList)
            {
                Console.WriteLine(country);
            }
            NavigateConsoleApp();
        }

        private static void AddCountryToList()
        {
            Console.Write("Enter the county name you want to add to the list: ");
            CountiesController.AddCountryToList(Console.ReadLine());
            PrintCountyList(CountiesController.GetCountryList());
        }
    }
}