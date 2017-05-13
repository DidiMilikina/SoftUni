using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            var capacitet = int.Parse(Console.ReadLine());
            var numberFans = int.Parse(Console.ReadLine());

            var prSectorA = 0.0;
            var prSectorB = 0.0;
            var prSectorV = 0.0;
            var prSectorG = 0.0;

            for (int i = 0; i <numberFans; i++)
            {
                string sector = Console.ReadLine();
                if(sector == "A")
                {
                    prSectorA++;
                }
                else if(sector == "B")
                {
                prSectorB++;
            }
            else if(sector == "V")
                {
                    prSectorV++;
                }
                else if(sector == "G")
                {
                    prSectorG++;
                }
                
            }

            double percentsA = (double)prSectorA / numberFans * 100;
            double percentsB = (double)prSectorB / numberFans * 100;
            double percentsV = (double)prSectorV / numberFans * 100;
            double percentsG = (double)prSectorG / numberFans * 100;

            double totalFans = (double)numberFans / capacitet * 100;

            Console.WriteLine($"{percentsA:f2}%");
            Console.WriteLine($"{percentsB:f2}%");
            Console.WriteLine($"{percentsV:f2}%");
            Console.WriteLine($"{percentsG:f2}%");
            Console.WriteLine($"{totalFans:f2}%");
        }
    }
}
