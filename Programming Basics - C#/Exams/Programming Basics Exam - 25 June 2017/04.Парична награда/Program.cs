using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Парична_награда
{
    class Program
    {
        static void Main(string[] args)
        {
            int separatedProject = int.Parse(Console.ReadLine());
            double moneyForOnePoint = double.Parse(Console.ReadLine());

            double points = 0;
            double totalPoints = 0;
            for (double i = 1; i <= separatedProject; i++)
            {

                points = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    points *= 2;
                    totalPoints += points;
                }
                else
                {
                    totalPoints += points;
                }
                
            }
            Console.WriteLine($"The project prize was {(moneyForOnePoint * totalPoints):f2} lv.");
        }
    }
}
