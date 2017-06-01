using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string output = "";
            for (int i = 1; i <= n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                char c = Convert.ToChar(currentNumber);
                output += c.ToString();
            }

            Console.WriteLine(output);
        }
    }
}
