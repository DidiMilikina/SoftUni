using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string result = "";

            for (int i = 1; i <= number; i++)
            {
                string words = Console.ReadLine();
                result += words + delimiter;
            }
            string sentence = result.Remove(result.Length - delimiter.Length, delimiter.Length);
            Console.WriteLine($"{sentence}");
        }
    }
}
