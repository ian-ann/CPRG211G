using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1_Module1_Classes
{
    internal class Person
    {
        public string Name { get; set; } //Field/Property
        public int Age { get; set; }

        
        public Person() 
        {
            Name = null; 
            Age = 0;
        }

        public Person(string name)
        {
            Name = name;
        }
        public Person(int age)
        {
            Age = age;
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(int age, string name)
        {
            Name = name;
            Age = age;
        }

        public void Rename(string name)
        {
            string Name = name;
            Console.WriteLine(Name);//
            this.Name = name;
            Console.WriteLine(this.Name);//
        }
        public override string ToString()
        {
            return $"{Name} is {Age} years old";
        }

    }
}
