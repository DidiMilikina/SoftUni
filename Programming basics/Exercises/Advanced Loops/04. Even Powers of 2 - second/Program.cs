using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_2___second
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n ; i+=2)
            {
                var currentValue = Math.Pow(2, i);
                Console.WriteLine(currentValue);
            }
        }
    }
}
