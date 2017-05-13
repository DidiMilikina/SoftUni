using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var yuan = double.Parse(Console.ReadLine());
            var comissionPercentage = double.Parse(Console.ReadLine());

            var bitcoinsInLeva = bitcoin * 1168;
            var yuansInDollars = yuan * 0.15;
            var dollarsInLeva = 1.76 * yuansInDollars;

            var totalInLeva = bitcoinsInLeva + dollarsInLeva;
            var euros = totalInLeva / 1.95;

            var comissionInEuro = comissionPercentage / 100 * euros;
            var totalEuros = euros - comissionInEuro;
            Console.WriteLine(totalEuros);

        }
    }
}
