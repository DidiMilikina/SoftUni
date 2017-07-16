using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSeconds = int.Parse(Console.ReadLine());
            var secondSeconds = int.Parse(Console.ReadLine());
            var thirdSeconds = int.Parse(Console.ReadLine());

            var totalSeconds = firstSeconds + secondSeconds + thirdSeconds;
            var minuts = totalSeconds / 60;
            var leftSeconds = totalSeconds % 60;
            if (leftSeconds >= 10)
            { Console.WriteLine($"{minuts}:{leftSeconds}"); }
            else
            { Console.WriteLine($"{minuts}:0{leftSeconds}"); }
        }
    }
}
