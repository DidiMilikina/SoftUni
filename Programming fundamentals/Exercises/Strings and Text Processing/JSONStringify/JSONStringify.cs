using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONStringify
{
    class JSONStringify
    {
        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int[] Grades { get; set; }
        }
        static void Main(string[] args)
        {
            var dataBase = new List<Student>();
            string input = Console.ReadLine();

            while (input != "stringify")
            {
                string[] inputParams = input
                    .Split(new[] { " ", ":", "-", ">", "," }
                        , StringSplitOptions.RemoveEmptyEntries);
                string studentName = inputParams[0];
                int age = int.Parse(inputParams[1]);
                int[] grades = inputParams
                    .Skip(2)
                    .Select(int.Parse)
                    .ToArray();

                Student newStudents = new Student();
                newStudents.Name = studentName;
                newStudents.Age = age;
                newStudents.Grades = grades;
                dataBase.Add(newStudents);

                input = Console.ReadLine();
            }
            Console.WriteLine(
                "[" +
                string.Join(",", dataBase.Select(x =>
                $"{{name:\"{x.Name}\",age:{x.Age},grades:[{string.Join(", ", x.Grades)}]}}")) 
                + "]");
        }
    }
}
