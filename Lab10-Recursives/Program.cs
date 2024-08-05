using System;

namespace NumberOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Addition
            Console.WriteLine("Addition");
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter number m: ");
            int m = int.Parse(Console.ReadLine());
            int sum = SumRecursive(n, m);
            Console.WriteLine(sum);

            // Division
            Console.WriteLine("Division");
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            int divisions = CountDivisionsByTwoRecursive(number);
            Console.WriteLine($"Total number of divisions: {divisions}");
        }

        // Method to calculate the sum of all numbers from n to m recursively
        static int SumRecursive(int n, int m)
        {
            if (n < 0 || m == 0 || n > m)
                return 0;

            return n + SumRecursive(n + 1, m);
        }

        // Method to count how many times a number can be evenly divided by 2
        static int CountDivisionsByTwoRecursive(int number)
        {
            if (number % 2 != 0 || number == 0)
                return 0;
            return 1 + CountDivisionsByTwoRecursive(number / 2);
        }
    }
}
