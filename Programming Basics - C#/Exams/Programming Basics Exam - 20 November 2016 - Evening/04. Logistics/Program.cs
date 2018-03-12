using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCargos = int.Parse(Console.ReadLine());
            double allCargos = 0;
            double cargoWithMicrobus = 0;
            double cargoWithCamion = 0;
            double cargoWithTrain = 0;

            for (int i = 0; i < numberOfCargos; i++)
            {
                var tone = double.Parse(Console.ReadLine());
               
                if (tone <= 3)
                {
                    cargoWithMicrobus += tone;
                }
                else if (tone >= 4 && tone <= 11)
                {
                    cargoWithCamion += tone;
                }
                else
                {
                    cargoWithTrain += tone;
                }
                allCargos += tone;
            }
            
            var totalCargos = cargoWithMicrobus + cargoWithCamion + cargoWithTrain;
            var cargoPerTone = (cargoWithMicrobus * 200 + cargoWithCamion * 175 + cargoWithTrain * 120) / totalCargos;
           

            Console.WriteLine($"{cargoPerTone:f2}");
            Console.WriteLine("{0:f2}%", cargoWithMicrobus / totalCargos * 100);
            Console.WriteLine("{0:f2}%", cargoWithCamion / totalCargos * 100);
            Console.WriteLine("{0:f2}%", cargoWithTrain / totalCargos * 100);

        }
    }
}
