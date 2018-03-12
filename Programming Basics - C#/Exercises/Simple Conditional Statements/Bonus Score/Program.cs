using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var number = double.Parse(Console.ReadLine());
            var bonusPoints = 0.0;
            if (number <= 100)
            { bonusPoints = 5; }

            else if (number > 100 && number <= 1000)
            { bonusPoints = number * 0.2; }

            else if (number > 1000)
            { bonusPoints = number * 0.1; }

            if (number % 2 == 0)
            { bonusPoints = bonusPoints + 1; }

            if (number % 10 == 5)
            { bonusPoints = bonusPoints + 2; }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + number);
        }
    }
}
