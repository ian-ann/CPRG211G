using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_0527b
{
    class Animal
    {
        public string Name {get; set; }//property
        public int Age {get; set; } 
        public virtual void Eat() // need to put the virtual for base class, override for derived class
        {
             Console.WriteLine($"{Name} is eating");
        }

        public virtual void Sleep()
        {
             Console.WriteLine($"{Name} is sleeping");
        }
    }

    class Dog: Animal { 
        public string Breed  { get; set; }
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking");
        }
        public override void Eat()
        {
             Console.WriteLine($"{Name} is eating1");
        }

        public override void Sleep()
        {
             Console.WriteLine($"{Name} is sleeping2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog()
            {
                Name = "Buddy",
                Breed = "Golden Retriever",
                Age = 3

            };
            dog.Eat();
            dog.Sleep();
            dog.Bark();
        }
    }
}
