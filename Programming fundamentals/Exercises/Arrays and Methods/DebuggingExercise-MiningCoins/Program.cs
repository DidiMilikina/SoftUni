using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingExercise_MiningCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = "";
            float totalValue = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int digit1 = number / 100;
                int digit2 = (number % 100) / 10;
                int digit3 = number % 10;

                totalValue += (digit1 + digit2 + digit3) / (float)n;
                int ASCIICode = 0;

                if (i % 2 != 0)
                {
                    ASCIICode = ((digit1 * 10) + digit3) - digit2;
                }
                else
                {
                    ASCIICode = ((digit1 * 10) + digit3) + digit2;
                }

                if ((ASCIICode >= 65 && ASCIICode <= 90)
                    || (ASCIICode >= 97 && ASCIICode <= 122))
                {
                    decrypted += (char)ASCIICode;
                }
            }

            Console.WriteLine($"Message: {decrypted}");
            Console.WriteLine($"Value: {totalValue:F7}");
        }
    }
}