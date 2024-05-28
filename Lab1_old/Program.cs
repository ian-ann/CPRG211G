using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Person
    {
            public int PersonId {get; set;}
            public string FirstName {get; set;}
            public string LastName {get; set;}
            public string FavoriteColour {get; set;}
            public int Age {get; set;}
            public bool IsWorking {get; set;}

        public string DisplayPersonInfo()
        {

            string name =  (FirstName + " " + LastName);

            Console.WriteLine(PersonId + ": " + name + "'s favorite color is: " + FavoriteColour);
            return name;

        }

        public void ChangeFavoriteColour() 
            {
                FavoriteColour = "white";
            }


        public int GetAgeInTenYears()
        {
            return Age + 10;

        }

        public override string ToString()
        {
            return $"PersonId: {PersonId}" +
                $"\nFirstName: {FirstName}" +
                $"\nLastName: {LastName} " +
                $"\nFavorite color: {FavoriteColour} " +
                $"\nAge: {Age}" +
                $"\nIs working: {IsWorking}";
        }
    }

    public enum RelationshipType
    {
        Sister,
        Brother,
        Mother,
        Father
    }

    class Relation
    {
        public void ShowRelationShip(Person person1, Person person2, RelationshipType relationship)
        {
            string relationshiptype = relationship.ToString();

            if (relationship == RelationshipType.Sister) 
                    {
                        relationshiptype = "Sisterhood";
                    }
            else if (relationship == RelationshipType.Brother)
                    {
                        relationshiptype = "Brotherhood";
                    }

            Console.WriteLine($"Relationshipe between {person1.FirstName} and {person2.FirstName} is {relationshiptype}");
        }
    }

    class Program
    {

        static void Main()
        {


                Person person1 = new Person()
                {
                    PersonId = 1,
                    FirstName = "Ian",
                    LastName = "Brooks",
                    FavoriteColour = "Red",
                    Age = 30,
                    IsWorking = true
                };

                Person person2 = new Person()
                {
                    PersonId = 2,
                    FirstName = "Gina",
                    LastName = "James",
                    FavoriteColour = "Green",
                    Age = 18,
                    IsWorking = false
                };

                Person person3 = new Person()
                {
                    PersonId = 3,
                    FirstName = "Mike",
                    LastName = "Briscoe",
                    FavoriteColour = "Blue",
                    Age = 45,
                    IsWorking = true
                };

                Person person4 = new Person()
                {
                    PersonId = 4,
                    FirstName = "Mary",
                    LastName = "Beals",
                    FavoriteColour = "Yellow",
                    Age = 28,
                    IsWorking = true
                };
                
            person2.DisplayPersonInfo();
            Console.WriteLine(person3.ToString());

            person1.ChangeFavoriteColour();
            person1.DisplayPersonInfo();

            Console.WriteLine($"{person4.FirstName}'s age after ten years: {person4.GetAgeInTenYears()}");

            Relation relation1 = new Relation();
            relation1.ShowRelationShip(person1, person4, RelationshipType.Sister);

            Relation relation2 = new Relation();
            relation1.ShowRelationShip(person1, person3, RelationshipType.Brother);

            List<Person> people = new List<Person> { person1, person2, person3, person4 };

            double averageAge = people.Average(p => p.Age);
            Console.WriteLine($"Average age: {averageAge}");

            Person youngest = people.OrderBy(p => p.Age).First();
            Person oldest = people.OrderByDescending(p => p.Age).First();
            Console.WriteLine($"The youngest person is: {youngest.FirstName} {youngest.LastName}\nOldenThe oldest  person is: {oldest.FirstName} {oldest.LastName}");

            var peopleWithM = people.Where(p => p.FirstName.StartsWith("M")).Select(p => p);
            Console.WriteLine(string.Join(", ", peopleWithM));

            Person personLikesBlue = people.FirstOrDefault(p => p.FavoriteColour == "Blue");
            if (personLikesBlue != null)
            {
                Console.WriteLine(personLikesBlue);
            }
            
        }
    }

}
