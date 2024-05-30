using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_0527
{
    class Person
    {
        public string name = "Calgary";
        public void Display()
        {
            Console.WriteLine("I am in a Base Class");
        }

        protected void View_data() //can only be accessible by the derived class
        { System.Console.WriteLine("Protected access specifier");
            }
    }

        class Employee : Person
        {
            public void get_name()
            {
                Console.WriteLine("I am in Derived Class");
                Console.WriteLine("The name is " + name);
            }
        }

        class Department:Employee
        {
            public void Display_dept()
            { 
                Console.WriteLine("THe employee department is Software Engineer");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
			    //create a object of derived class to access base class also
			    Department e = new Department();
			    e.Display(); //base class method invoked
			    e.get_name();
			    e.Display_dept();//derived class method invoked
			    Console.ReadLine();
            }
        }
    }
