using System;


namespace Demo1_Module1_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal a1 = new Animal("Fido", 20);
            Console.WriteLine("1. Name=" + a1.Name + ", Age " + a1.Age);
            ModifyAnimal(out a1);
            Console.WriteLine("3. Name=" + a1.Name + ", Age " + a1.Age);

            /*
            Animal a2 = new Animal("Fido", 20);

            Animal a3 = a1;

            if(a1.Equals(a2)) {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            if (a1 == a3)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            /*Animal animal1 = new Animal();
            animal1.Name = "Max";


            animal1.Name = "Fido";
            animal1.Age = 6;
            animal1.Species = "Dog";
            animal1.Deit = Diet.Omnivore;

            string[] hab = { "Running", "Eating"};
            animal1.Habitats = hab;

            Person tc= new Person();
            tc.Name= "Mike";
            tc.Age= 40;

            animal1.CareTaker = tc;

            Console.WriteLine(animal1.Name);
            Console.WriteLine(animal1.Age);
            Console.WriteLine(animal1.Species);
            Console.WriteLine(animal1.Deit);
            Console.WriteLine(animal1.Habitats[0]);
            Console.WriteLine(animal1.CareTaker.Name);
            Console.WriteLine(animal1.CareTaker.Age);
            //Console.WriteLine("Welcome");


            Console.WriteLine(animal1.MakeSound());

            animal1.Sleep();
            animal1.SleepForSeconds(200);
           

            Animal animal2 = new Animal();

            Animal animal3 = new Animal();
            
            Console.WriteLine(Animal.Population);
            Console.WriteLine(Animal.GetPopulation());

          //  animal1.PrintPopulationAfter10Years();


            Person p1 = new Person();

            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);

            Person p2 = new Person("Ali");
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.Age);

            Person p3 = new Person("Ali", 20);

            Person p4 = new Person(20, "Ali");


            Console.WriteLine(p3.ToString());

            Console.WriteLine("-------------------");
            p3.Rename("Al");
            Console.WriteLine(p3.Name);
            Console.WriteLine("-------------------");
           
            Calculator c = new Calculator();
            Console.WriteLine(c.Add(2, 3));

            Console.WriteLine(Calculator.Add(2.5, 3.5));

            Console.WriteLine(c.Add("Hello ", "Hi"));
            Console.WriteLine(c.Add("Hello ", 5));
 */
            Console.ReadKey(true);
        }

        private static void ModifyAnimal(out Animal a)
        {
            a = new Animal("Test", 3);           
            Console.WriteLine("2. Name=" + a.Name + ", Age " + a.Age);
        }
    }
}
