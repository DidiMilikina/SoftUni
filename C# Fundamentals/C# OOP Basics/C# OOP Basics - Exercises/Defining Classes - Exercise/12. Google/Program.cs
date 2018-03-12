using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Google
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> persons = new List<Person>();

            while (input != "End")
            {
                var tokens = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string personName = tokens[0];

                if (!persons.Any(p => p.name == personName))
                {
                    persons.Add(new Person(personName));
                }

                string command = tokens[1];
                Person person = persons.Where(p => p.name == personName).First();

                switch (command)
                {
                    case "company":
                        string companyName = tokens[2];
                        string department = tokens[3];
                        decimal salary = decimal.Parse(tokens[4]);

                        person.company = new Company(companyName, department, salary);
                        break;

                    case "pokemon":
                        string pokemonName = tokens[2];
                        string pokemonType = tokens[3];

                        person.pokemons.Add(new Pokemon(pokemonName, pokemonType));
                        break;

                    case "parents":
                        string parentName = tokens[2];
                        string parentBirthday = tokens[3];

                        person.parents.Add(new Parent(parentName, parentBirthday));
                        break;

                    case "children":
                        string childName = tokens[2];
                        string childBirthday = tokens[3];

                        person.children.Add(new Child(childName, childBirthday));
                        break;

                    case "car":
                        string model = tokens[2];
                        int speed = int.Parse(tokens[3]);

                        person.car = new Car(model, speed);
                        break;
                }

                input = Console.ReadLine();
            }

            string currentName = Console.ReadLine();

            Person currentPerson = persons.Where(p => p.name == currentName).First();

            Console.WriteLine(currentPerson.name);
            Console.WriteLine("Company:");

            if (currentPerson.company != null)
            {
                Console.WriteLine(currentPerson.company);
            }
            Console.WriteLine("Car:");

            if (currentPerson.car != null)
            {
                Console.WriteLine(currentPerson.car);
            }

            Console.WriteLine("Pokemon:");
            currentPerson.pokemons.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("Parents:");
            currentPerson.parents.ForEach(p => Console.WriteLine(p));

            Console.WriteLine("Children:");
            currentPerson.children.ForEach(c => Console.WriteLine(c));
        }
    }
}
