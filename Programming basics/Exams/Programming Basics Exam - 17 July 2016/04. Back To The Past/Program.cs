using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var ancestralMoney = double.Parse(Console.ReadLine());
            var yearsShouldLive = int.Parse(Console.ReadLine());
            var years = 18;

            for (int i = 1800; i <= yearsShouldLive; i++)
            {
                if (i % 2 == 0)
                {
                    ancestralMoney -= 12000;
                }
                else
                {
                    ancestralMoney -= (12000 + 50 * years);
                }
                years++;
            }
            if (ancestralMoney < 0)
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs(ancestralMoney));
            }
            else
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", ancestralMoney);
            }

        }
    }
}
