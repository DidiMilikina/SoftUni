using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            var priceExcursion = double.Parse(Console.ReadLine());
            var numPuzzles = int.Parse(Console.ReadLine());
            var numSpeekDolls = int.Parse(Console.ReadLine());
            var numTeddyBears = int.Parse(Console.ReadLine());
            var numMinions = int.Parse(Console.ReadLine());
            var numKamions = int.Parse(Console.ReadLine());

            var puzzle = 2.6;
            var speekDoll = 3.0;
            var teddyBear = 4.1;
            var minion = 8.2;
            var kamion = 2.0;

            var sum = numPuzzles * puzzle + numSpeekDolls * speekDoll + numTeddyBears * teddyBear + numMinions * minion + numKamions * kamion;
            var numToys = numPuzzles + numSpeekDolls + numTeddyBears + numMinions + numKamions;

            if(numToys >= 50)
            {
                var sumO = numPuzzles * puzzle + numSpeekDolls * speekDoll + numTeddyBears * teddyBear + numMinions * minion + numKamions * kamion;
                sumO *= 0.75;
                var price = sum - sumO;
                var pechalba = sumO * 0.9;
                var naem = sumO * 0.9;

                if(pechalba >= priceExcursion)
                {
                    var moneyLeft = pechalba - priceExcursion;
                    Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
                }
                else
                {
                    
                    Console.WriteLine($"Not enough money! {(priceExcursion - pechalba):f2} lv needed.");
                }
            }
            else
            {
                var pechalbaNo = sum * 0.9;
                var naemNo = sum - pechalbaNo;
                if(pechalbaNo < priceExcursion)
                {
                    Console.WriteLine($"Not enough money! {(priceExcursion - pechalbaNo):f2} lv needed.");
                }
            }
        }
    }
}
