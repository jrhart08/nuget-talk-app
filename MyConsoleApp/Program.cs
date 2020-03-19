using System;
using NdashLib;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            var (evens, odds) = numbers.Partition(num => num % 2 == 0);

            Console.WriteLine($"Evens: {string.Join(",", evens)}");
            Console.WriteLine($"Odds: {string.Join(",", odds)}");
        }
    }
}
