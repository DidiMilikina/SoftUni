using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var happyDays = double.Parse(Console.ReadLine());
            var weeksReturnHome = double.Parse(Console.ReadLine());
            var weekInYear = 48;
            var weekends = (weekInYear - weeksReturnHome) * 3 / 4;
            var sofiaPlays = happyDays * 2 / 3;
            var totalGames = weekends + sofiaPlays + weeksReturnHome;
            if (year == "leap") { totalGames = totalGames * 1.15; }
            Console.WriteLine(Math.Floor(totalGames));
        }
    }
}
