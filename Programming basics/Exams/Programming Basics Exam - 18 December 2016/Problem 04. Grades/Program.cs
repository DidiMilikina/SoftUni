using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            var graterThanFive = 0.0;
            var betweenFourAndFive = 0.0;
            var betweenThreeAndFour = 0.0;
            var poorerThanThree = 0.0;
            var average = 0.0;

            for (int  i = 0;  i < numberOfStudents;  i++)
            {
                var grade = double.Parse(Console.ReadLine());
                if(grade >= 5.00)
                {
                    graterThanFive++;
                }
                if(grade >= 4.00 && grade <= 4.99)
                {
                    betweenFourAndFive++;
                }
                if(grade >= 3 && grade <= 3.99)
                {
                    betweenThreeAndFour++;
                }
                if (grade < 3)
                {
                    poorerThanThree++;
                }
                average += grade;
            }

            Console.WriteLine($"Top students: {((graterThanFive / numberOfStudents) * 100):f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {((betweenFourAndFive / numberOfStudents) * 100):f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {((betweenThreeAndFour / numberOfStudents) * 100):f2}%");
            Console.WriteLine($"Fail: {((poorerThanThree / numberOfStudents) * 100):f2}%");
            Console.WriteLine($"Average: {(average / numberOfStudents):f2}");
        }
    }
}
