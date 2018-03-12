using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            Console.WriteLine(DateModifier.GetDaysBetweenDates(firstDate, secondDate));
        }
    }
}
