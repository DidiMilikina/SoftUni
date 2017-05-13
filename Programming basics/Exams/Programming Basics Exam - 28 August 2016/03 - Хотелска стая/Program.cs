using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studio = 0.00;
            var apartment = 0.00;
            if(month == "May" || month == "October")
            { 
                studio = 50;
                apartment = 65;
            }
            else if(month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;
            }
            else
            {
                studio = 76;
                apartment = 77;
            }

            if (nights > 14 && (month == "May" || month == "October"))
            {
                studio -= studio * 0.3;
            }
            else if (nights > 7 && (month == "May" || month == "October"))
            {
                studio -= studio * 0.05;
            }
            
            if(nights > 14 && (month == "June" || month == "September"))
            {
                studio -= studio * 0.2;
            }
            if (nights > 14)
            {
                apartment -= apartment * 0.1;
            }

            Console.WriteLine($"Apartment: {apartment * nights:f2} lv.");
            Console.WriteLine($"Studio: { nights * studio:f2} lv.");
           
        }
    }
}
