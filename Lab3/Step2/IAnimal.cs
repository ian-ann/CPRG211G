using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3b
{
    interface IAnimal
    {
        string Name { get; set;}
        string Colour { get; set;}
        double Height { get; set; }
        int Age { get; set; }

        void Eat();
        string Cry();
    }
}
