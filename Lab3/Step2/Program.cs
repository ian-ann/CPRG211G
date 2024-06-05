using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Dog's name: ");
            string dogName = Console.ReadLine();
            Console.Write("Enter Dog's colour: ");
            string dogColour = Console.ReadLine();
            Console.Write("Enter Dog's age: ");
            int dogAge = int.Parse(Console.ReadLine());
            Console.Write("Enter Dog's height: ");
            double dogHeight = double.Parse(Console.ReadLine());
            Dog myDog = new Dog
            {
                Name = dogName,
                Colour = dogColour,
                Age = dogAge,
                Height = dogHeight
            };

            // Print dog properties
            Console.WriteLine($"\nDog's name: {myDog.Name}");
            Console.WriteLine($"Dog's colour: {myDog.Colour}");
            Console.WriteLine($"Dog's age: {myDog.Age}");
            Console.WriteLine($"Dog's height: {myDog.Height}");
            myDog.Eat();
            myDog.Cry();

            Console.Write("\nEnter Cat's name: ");
            string catName = Console.ReadLine();
            Console.Write("Enter Cat's colour: ");
            string catColour = Console.ReadLine();
            Console.Write("Enter Cat's age: ");
            int catAge = int.Parse(Console.ReadLine());
            Console.Write("Enter Cat's height: ");
            double catHeight = double.Parse(Console.ReadLine());
            Cat myCat = new Cat
            {
                Name = catName,
                Colour = catColour,
                Age = catAge,
                Height = catHeight
            };

            // Print Cat properties
            Console.WriteLine($"\nCat's name: {myCat.Name}");
            Console.WriteLine($"Cat's colour: {myCat.Colour}");
            Console.WriteLine($"Cat's age: {myCat.Age}");
            Console.WriteLine($"Cat's height: {myCat.Height}");
            myCat.Eat();
            myCat.Cry();

            // Create a list of animals
            List<IAnimal> animals = new List<IAnimal> { myDog, myCat };

            // Print names of all animals
            Console.WriteLine("\nNames of all animals:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
