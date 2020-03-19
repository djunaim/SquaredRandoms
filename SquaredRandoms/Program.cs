using System;
using System.Collections.Generic;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> squaredNumsList = new List<int> { };

            var randomNums = new RandomNum();
            foreach (var randomNum in randomNums.RandomNumbersList)
            {
                Console.WriteLine(randomNum);
            }

            foreach (var randomNum in randomNums.RandomNumbersList)
            {
                var squaredNums = randomNum * randomNum;
                squaredNumsList.Add(squaredNums);
                Console.WriteLine(squaredNums);
            }

            foreach (var evenNum in squaredNumsList)
            {
                if (evenNum % 2 == 0)
                {
                    Console.WriteLine($"This is even numbers: {evenNum}");
                }
            }
        }
    }
}
