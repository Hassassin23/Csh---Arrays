using System;

namespace ReversedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    numbers[i] = number;
            //}

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int CurrentNum = int.Parse(Console.ReadLine());
                numbers[i] = CurrentNum;
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
