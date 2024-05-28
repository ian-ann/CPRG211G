using System;

namespace Demo1_Module1_Classes
{
    class Animal
    {
        public const double PI = Math.PI;
        public const int NUMBER_OF_WEEK_DAYS = 7;
        
        private string name;
        

        public string Name {
            get { return name; }

            set 
            { 
                name = value; 
            }
        
        }
        public int Age { get; set; }
        public string Species { get; set; }

        public bool IsEndangered { get; set; }

        public string[] Habitats { get; set; }
        public int[] Heights { get; set; }

        public Diet Deit { get; set; }

        public Person CareTaker { get; set; }

        public static int Population = 0;

        public Animal()
        {
            Population++; // Population = Popluation + 1
        }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static int GetPopulation() 
        { 
            return Population; 
        }


        public string MakeSound()
        {
            return "Some sound";
        }

        public void Sleep()
        {
            Console.WriteLine("Every animal sleeps");
        }

        public void SleepForSeconds(int seconds)
        {
            Console.WriteLine(seconds);
        }

        private void PrintPopulationAfter10Years()
        {
            int p10 = Population + Population * 5;
            Console.WriteLine("Population after 10 years "  + p10);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    
    enum Diet
    {
        Carnivore,
        Herbivore,
        Omnivore
    }
}
