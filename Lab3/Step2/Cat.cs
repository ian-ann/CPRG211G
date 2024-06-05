using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3b
{
    class Cat : IAnimal  //changed from Animal to IAnimal as per Step2
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice");
        }

        public string Cry()
        {
            string cry = "Meow!";
            Console.WriteLine(cry);
            return cry;
        }
    }
}
