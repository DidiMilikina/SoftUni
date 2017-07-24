using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParse
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Grades { get; set; }
    }

    class JSONParse
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                var currentStudent = input[i]
                    .Split(new[] {'[', '{', ':', ',', ' ', '}', ']'},
                    StringSplitOptions.RemoveEmptyEntries);

                Student newStudent = new Student();
                
                

            }
            
        }
    }
}
