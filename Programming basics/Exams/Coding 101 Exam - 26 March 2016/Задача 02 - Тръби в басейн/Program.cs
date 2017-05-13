using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            var volumeInLiters = int.Parse(Console.ReadLine());
            var debitFirstPipe = int.Parse(Console.ReadLine());
            var debitSecondPipe = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            var totalDebitFirstPipe = hours * debitFirstPipe;
            var totalDebitSecondPipe = hours * debitSecondPipe;
            var totalDebit = totalDebitFirstPipe + totalDebitSecondPipe;
            if (totalDebit > volumeInLiters)
            {

                Console.WriteLine($"For {hours} hours the pool overflows with {totalDebit - volumeInLiters} liters.");
            }
            else
            {
                var percent = Math.Floor(totalDebit / volumeInLiters * 100);
                var percentFirstPipe = Math.Floor(totalDebitFirstPipe / totalDebit * 100);
                var percentSecondPipe = Math.Floor(totalDebitSecondPipe / totalDebit * 100);

                Console.WriteLine($"The pool is {percent}% full. Pipe 1: {percentFirstPipe}%. Pipe 2: {percentSecondPipe}%.");

            }
        }
    }
}