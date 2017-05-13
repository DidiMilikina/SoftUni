using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var difference = 0;
            var previous = 0;
            var maxDiff = 0;
            for (int i = 0; i < n; i++)
            {
                var n1 = int.Parse(Console.ReadLine());
                var n2 = int.Parse(Console.ReadLine());
                sum = n1 + n2;
                difference = Math.Abs(n1 + n2 - previous);
                previous = sum;
                if (difference > maxDiff && sum != difference)
                {
                    maxDiff = difference;
                }
            }

            if (difference != 0 && sum != difference)
            {
                Console.WriteLine("No, maxdiff={0}", maxDiff);
            }
            else
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
        }
    }
    }
