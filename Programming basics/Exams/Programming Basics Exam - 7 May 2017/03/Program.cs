using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var typeOfGroup = Console.ReadLine();
            var numberStudents = int.Parse(Console.ReadLine());
            var numNights = int.Parse(Console.ReadLine());


         if(numberStudents > 50)
            {

            }
            if(season == "Winter")
            {

                var girls = 9.6;
                var boys = 9.6;
                var smesena = 10;
               

                if(typeOfGroup == "girls")
                {
                    var total = numberStudents * numNights * 9.6;
                    var otstupka = total - (total * 0.85);
                    Console.WriteLine($"Gymnastics {otstupka} lv.");
                }
                else if(typeOfGroup == "boys")
                {
                    var total = numberStudents * numNights * 9.6;
                    var otstupka = total - (total * 0.85);
                    Console.WriteLine($"Judo {otstupka} lv.");
                }
                else
                {
                    var total = numberStudents * numNights * 10;
                    var otstupka = total - (total * 0.85
                    Console.WriteLine($"Ski {numberStudents * numNights * 10} lv.");
                }
               
            }
            else if(season == "Spring")
            {
                var girlsSpring = 7.2;
                var boysSpring = 7.2;
                var smesenaSpring = 9.5;

                if (typeOfGroup == "girls")
                {
                    Console.WriteLine($"Athletics {numberStudents * numNights * girlsSpring} lv.");
                }
                else if (typeOfGroup == "boys")
                {

                    Console.WriteLine($"Tennis {numberStudents * numNights * boysSpring} lv.");
                }
                else
                {
                    Console.WriteLine($"Cycling {numberStudents * numNights * smesenaSpring} lv.");
                }
            }
            else
            {
                var girlsSummer = 15;
                var boysSummer = 15;
                var smesenaSummer = 20;

                if (typeOfGroup == "girls")
                {
                    Console.WriteLine($"Volleyball {numberStudents * numNights * girlsSummer} lv.");
                }
                else if (typeOfGroup == "boys")
                {

                    Console.WriteLine($"Football {numberStudents * numNights * boysSummer} lv.");
                }
                else
                {
                    Console.WriteLine($"Swimming {numberStudents * numNights * smesenaSummer} lv.");
                }
            }

            
           }
        }
    }
}
