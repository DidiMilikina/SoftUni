using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageLilly = int.Parse(Console.ReadLine());
            var priceLaundry = double.Parse(Console.ReadLine());
            var pricePerToy = int.Parse(Console.ReadLine());

            var savedMoney = 0;
            var moneyFromGifts = 0;
            var bonus = 10;
            for (int i = 1; i <= ageLilly; i++)
            {
                if(i % 2 == 0)
                {
                    savedMoney += bonus;
                    savedMoney = savedMoney - 1;
                    bonus = bonus + 10;
                }
                else
                {
                    savedMoney += pricePerToy;
                }
            }

            var allMoney = savedMoney + moneyFromGifts;
            if (allMoney >= priceLaundry)
            {
                var enough = allMoney - priceLaundry;
                Console.WriteLine($"Yes! {enough:F2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceLaundry - allMoney):F2}");
            }
        }
    }
}
