using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageEmployee = new Dictionary<string, int>();
            var salaryEmployee = new Dictionary<string,double>();
            var positionEmployee = new Dictionary<string, string>();

            string[] tokens = Console.ReadLine()
                .Split(" -> ".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);

            while (tokens[0] != "filter")
            {
                string name = tokens[0];
                string value = tokens[1];

                int age;
                double salary;

                if (int.TryParse(value, out age))
                {
                    ageEmployee[name] = age;
                }
                else if (double.TryParse(value, out salary))
                {
                    salaryEmployee[name] = salary;
                }
                else
                {
                    positionEmployee[name] = value;
                }

                tokens = Console.ReadLine()
                    .Split(" -> ".ToCharArray(),
                        StringSplitOptions.RemoveEmptyEntries);

            }
            string condition = Console.ReadLine().ToLower();
            if (condition == "position")
            {
                foreach (var employee in positionEmployee)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Position: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (condition == "age")
            {
                foreach (var employee in ageEmployee)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Age: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (var employee in salaryEmployee)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Salary: {employee.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}