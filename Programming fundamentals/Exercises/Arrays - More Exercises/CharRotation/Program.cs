using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int[] number = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if(number[i] % 2 == 0)
                {
                    result += (char)(text[i] - number[i]);
                }
                else
                {
                    result += (char)(text[i] + number[i]);
                }
            }
            Console.WriteLine(result);
        }
    }
}
