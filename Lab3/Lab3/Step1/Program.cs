using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Dog's name: ");
            string dogName = Console.ReadLine();
            Dog myDog = new Dog();
            myDog.Name = dogName;
            myDog.Colour = "Pied";
            myDog.Age = 3;

            // Print dog properties
            Console.WriteLine($"Dog's name: {myDog.Name}");
            Console.WriteLine($"Dog's colour: {myDog.Colour}");
            Console.WriteLine($"Dog's age: {myDog.Age}");
            myDog.Eat();

            Console.Write("\nEnter Cat's name: ");
            string catName = Console.ReadLine();
            Cat myCat = new Cat();
            myCat.Name = catName;
            myCat.Colour = "Black";
            myCat.Age = 4;

            // Print Cat properties
            Console.WriteLine($"Cat's name: {myCat.Name}");
            Console.WriteLine($"Cat's colour: {myCat.Colour}");
            Console.WriteLine($"Cat's age: {myCat.Age}");


        }
    }
}
