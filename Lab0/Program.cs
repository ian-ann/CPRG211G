using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    internal class Program
    {
        private static List<double> ListOfNumbers = new List<double>(); // Private list accessible within the class

        static void Main(string[] args)
        {
            string projectPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(),"../.."));
            string filepath = Path.Combine(projectPath, "numbers.txt");

            double lowNum = GetLowNumber();
            double highNum = GetHighNumber(lowNum);
            double difference = highNum - lowNum;

            // Calculate and print out the difference (logic not provided in original code)
            Console.WriteLine($"The difference between {highNum} and {lowNum} is: {difference}");

            // Option 1: Using Array
            // int[] ListOfNumbers;
            // for (int i = lowNum; i < highNum; i++)
            // {
            //     ListOfNumbers = new int[i];
            // }
            // int[] ListOfNumbers = new int[lowNum];
            // int[] ListOfNumbers = new int[highNum];

            // Option 2: Using List
            for (double i = lowNum + 1 ; i < highNum; i++)
            {
                ListOfNumbers.Add(i);
            }

            WriteNumbersToFile(ListOfNumbers, filepath);
            ReadAndSumNumbersFromFile(filepath);

        }

        static int GetLowNumber()
        {
            int newLow;
            Console.Write("Please enter a low number: ");

            while (true)
            {
                string userInput = Console.ReadLine();
                //Converting string into integer
                bool t = int.TryParse(userInput, out newLow);
                if (t && newLow > 0)
                {
                    return newLow;
                }
                else
                {
                    Console.Write("Invalid input, please re-enter a positive low number: ");
                }
            }
        }

        static int GetHighNumber(double _lowNum) 
        {
            int newHigh;
            Console.Write("Please enter a high number: ");
            while (true)
            {
                string userInput = Console.ReadLine();
                //Converting string into integer
                bool t = int.TryParse(userInput, out newHigh);
                if (t && newHigh > _lowNum)
                {
                    return newHigh;
                }
                else
                {
                    Console.WriteLine($"Invalid input, please re-enter a number greater than: {_lowNum}");
                }
            }
        }

        static void WriteNumbersToFile(List<double> _numbers, string _filePath)
        {
            _numbers.Reverse();
            using (StreamWriter writer = new StreamWriter(_filePath))
            {
                foreach (int number in _numbers)
                    {
                        writer.WriteLine(number);
                    }
            }
        }

        static void ReadAndSumNumbersFromFile(string _filePath)
        { 
            double sum = 0;
            Console.WriteLine("\nRead the numbers for numbers.txt file\n");
            using (StreamReader reader = new StreamReader(_filePath))
            {
              string line;
              while ((line = reader.ReadLine()) != null)
              {
                sum += double.Parse(line);
                if(IsPrime(double.Parse(line)))
                    { 
                        Console.WriteLine($"{double.Parse(line)} is a prime number");
                     }
              }
            }

            Console.WriteLine($"\nSum of numbers in the file: {sum}");
        }
        
        static bool IsPrime(double number)
        {
            if (number <= 1) return false;  // 1 and below are not prime
            if (number <= 3) return true;   // 2 and 3 are prime

            // Check divisibility only by odd numbers from 3 to sqrt(num)
            for (double i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
