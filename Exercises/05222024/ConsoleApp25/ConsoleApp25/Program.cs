using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;


namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            String filepath = @"C:\Users\ksehmi\source\repos\ConsoleApp25\ConsoleApp25\TextFile1.txt";
            //string[] lines = File.ReadAllLines(filepath);
            List<string> lines = new List<string>();
            lines=File.ReadAllLines(filepath).ToList();
            foreach(string line in lines) 
            { 
                Console.WriteLine(line);    
            }
            lines.Add("hellonew strig");
            
            File.WriteAllLines(filepath, lines);

            Console.ReadLine();

        }
    }
}
