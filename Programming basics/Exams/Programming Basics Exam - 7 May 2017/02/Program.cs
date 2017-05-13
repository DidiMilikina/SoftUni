using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceExcursion = double.Parse(Console.ReadLine());
            var numPuzzles = int.Parse(Console.ReadLine());
            var numSpeekDols = int.Parse(Console.ReadLine());
            var numPlusheniMecheta = int.Parse(Console.ReadLine());
            var numMinions = int.Parse(Console.ReadLine());
            var numKamions = int.Parse(Console.ReadLine());

            var puzzle = 2.6;
            var speekDol = 3;
            var plushenoMeche = 4.1;
            var minion = 8.2;
            var kamion = 2;

            var sum = numPuzzles * puzzle + numSpeekDols * speekDol + numPlusheniMecheta * plushenoMeche + numKamions * kamion + numMinions * minion;
            var numDolls = numPuzzles + numSpeekDols + numPlusheniMecheta + numMinions + numKamions;

            

            if(numDolls > 50)
            {
                var otstupka = sum * 0.75;
                var total = sum - otstupka;
                var pechalba = otstupka * 0.9;
               
 if(pechalba > priceExcursion)
                {
                    var moneyLeft = pechalba - priceExcursion;
Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! {priceExcursion - pechalbaB:f2} lv needed.");
                }
                
                
            }
            else
            {
                var naemO = sum * 0.9;
                var naemF = sum - naemO;
                var pechalbaB = sum - naemF;
                if (pechalbaB < priceExcursion)
                {
                    Console.WriteLine($"Not enough money! {priceExcursion - pechalbaB:f2} lv needed.");
                }
            }
        }
    }
}
