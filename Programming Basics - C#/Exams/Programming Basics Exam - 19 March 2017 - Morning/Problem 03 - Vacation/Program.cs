using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if(budget <= 1000)
            {
                
                if(season == "Summer")
                {
                    var price = budget * 0.65;
                    Console.Write("Alaska - " + "Camp - ");
                    Console.WriteLine($"{price:F2}");
                }
                else if(season == "Winter")
                {
                    var price = budget * 0.45;
                    Console.Write($"Morocco - " + "Camp - ");
                    Console.WriteLine($"{price:F2}");
                }
              
            }
            else if(budget > 1000 && budget <= 3000)
            {
                
                if(season == "Summer")
                {
                    var price = budget * 0.8;
                    Console.Write("Alaska - " + "Hut - ");
                    Console.WriteLine($"{price:F2}");
                }
                
                else if(season == "Winter")
                {
                    var price = budget * 0.6;
                    Console.Write($"Morocco - " + "Hut - ");
                    Console.WriteLine($"{ price:F2}");
                }
               
            }
            else
            {
                
                var price = budget * 0.9;
                if(season == "Summer")
                {
                    Console.Write("Alaska - " + "Hotel - ");
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    Console.Write("Morocco - " + "Hotel - ");
                    Console.WriteLine($"{price:F2}");
                }
               
            }
        }
    }
}
