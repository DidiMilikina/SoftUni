using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            var restDays = int.Parse(Console.ReadLine());
            var workingDays = 365 - restDays;
            var playTime = (workingDays * 63) + (restDays * 127);
            var difference = playTime - 30000;
            var hours = Math.Abs(difference / 60);
            var minutes = Math.Abs(difference % 60);

            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
