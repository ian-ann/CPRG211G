using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3a
{
    class Dog : Animal
    {
        public override void Eat() { 
            Console.WriteLine("Dogs eat meat.");
        }
    }
}
