using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();

            var datTime = DateTime.ParseExact(date,
                "d-M-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(datTime.DayOfWeek);
        }
    }
}
