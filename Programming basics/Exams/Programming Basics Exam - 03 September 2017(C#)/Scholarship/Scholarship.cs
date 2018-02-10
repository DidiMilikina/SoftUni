using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Scholarship
    {
        static void Main(string[] args)
        {
            double incomeInLv = double.Parse(Console.ReadLine());
            double average = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double social = 0;
            double excellentGrade = 0;

            if ((average > 4.5) && (incomeInLv < minimalSalary))
            {
                social = Math.Floor(minimalSalary * 0.35);
            }

            if (average >= 5.5)
            {
                excellentGrade = Math.Floor(average * 25);
            }

            if ((excellentGrade > 0) && (excellentGrade >= social))
            {
                Console.WriteLine($"You get a scholarship for excellent results {excellentGrade} BGN");
            }
            else if (social > 0)
            {
                Console.WriteLine($"You get a Social scholarship {social} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
