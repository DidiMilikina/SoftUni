using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            Person[] persons = new Person[people];

            for (int i = 0; i < people; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                persons[i] = new Person(name, age);
            }

            List<Person> orderedPersons = persons
                .OrderBy(p => p.name)
                .Where(p => p.age > 30)
                .ToList();

            foreach (var print in orderedPersons)
            {
                Console.WriteLine($"{print.name} - {print.age}");
            }
        }
    }
}
