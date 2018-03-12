using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Family_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var familyInput = new List<Person>();
            var input = new List<string>();
            var personInfo = Console.ReadLine();
            var command = Console.ReadLine();

            while (command != "End")
            {
                if (command.Contains("-"))
                {
                    input.Add(command);
                    command = Console.ReadLine();
                    continue;
                }

                var personInput = command.Split().ToArray();

                var firstName = personInput[0];
                var lastName = personInput[1];
                var date = personInput[2];

                if (!familyInput.Any(p => p.FirstName == firstName && p.LastName == lastName))
                {
                    var person = new Person(firstName, lastName, date);
                    familyInput.Add(person);
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < input.Count; i++)
            {
                var childParentInfo = input[i].Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                var parentInfo = childParentInfo[0].Trim();
                var childInfo = childParentInfo[1].Trim();
                var parent = new Person();
                var child = new Person();

                parent = AddParentAndChildInfo(parentInfo, familyInput, parent);
                child = AddParentAndChildInfo(childInfo, familyInput, child);

                child.Parents.Add(parent);
                parent.Children.Add(child);
            }

            var personResult = new Person();
            if (!personInfo.Contains("/"))
            {
                var nameInfo = personInfo.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                personResult = familyInput.FirstOrDefault(p => p.FirstName == nameInfo[0] && p.LastName == nameInfo[1]);
            }
            else
            {
                personResult = familyInput.FirstOrDefault(p => p.Birthday == personInfo);
            }

            Console.WriteLine(personResult);
        }

        public static Person AddParentAndChildInfo(string personInfo, List<Person> family, Person person)
        {
            if (personInfo.Contains("/"))
            {
                person = family.FirstOrDefault(p => p.Birthday == personInfo);
            }
            else
            {
                var nameInfo = personInfo.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                person = family.FirstOrDefault(p => p.FirstName == nameInfo[0] && p.LastName == nameInfo[1]);
            }
            return person;
        }
    }
}
