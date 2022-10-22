using System;
using System.Linq;

namespace ReversedStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine()
                .Split(" ")
                .ToArray();

            for (int i = letters.Length - 1; i >= 0; i--)
            {
                Console.Write($"{letters[i]} ");
            }
        }
    }
}
