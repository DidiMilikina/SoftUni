using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            var str1 = $"{number1:D4}";
            var str2 = $"{number2:D4}";
            var str3 = $"{number3:D4}";
            var str4 = $"{number4:D4}";

            Console.Write($"{str1+" "}");
            Console.Write($"{str2+ " "}");
            Console.Write($"{str3+ " "}");
            Console.WriteLine($"{str4}");
        }
    }
}
