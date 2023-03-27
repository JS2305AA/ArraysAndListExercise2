using System;
using System.Collections.Generic;

namespace ArraysAndListsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create int array and populate numbers 1-10.
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Create two lists of type int. Name one even and name one odd.
            var evens = new List<int>();
            var odds = new List<int>();

            //use for, or foreach loop to check if number is even or odd.
            //Add those numbers to the evens, or to the odds list.
            foreach (var num in numbers)
            {
                
                if (num % 2 == 0)
                {
                    evens.Add(num); //Add to evens list
                }
                else
                {
                    odds.Add(num); //Add to odds list
                }
            }

            foreach (var item in evens)
            {
                Console.WriteLine($"{item} is an even number");
            }

            foreach (var oddNumber in odds)
            {
                Console.WriteLine($"{oddNumber}");
            }
        }
    }
}
