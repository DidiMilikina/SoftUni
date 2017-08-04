using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParse
{
   
    class JSONParse
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            input = input
                .Substring(2, input.Length - 2 - 2);
                string[] student = input
                    .Split(new[] { "},{" },
                    StringSplitOptions.RemoveEmptyEntries);
            foreach (var currentStudent in student)
            {
                string[] properties = currentStudent
                    .Split(new string[] { ",age:", ",grades:"},
                    StringSplitOptions.RemoveEmptyEntries);
                string name = properties[0]
                    .Substring(6, properties[0].Length - 1 - 6);
                string age = properties[1];
                string grades = properties[2]
                    .Substring(1, properties[2].Length - 1 - 1);

                if (grades == string.Empty)
                {
                    grades = "None";
                }

                Console.WriteLine($"{name} : {age} -> {grades}");
            }
        }
    }
}
