using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingExercise_TrickyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var numberOfStrings = int.Parse(Console.ReadLine());
            var result = string.Empty;
            var currentString = string.Empty;

            for (int i = 1; i <= numberOfStrings; i++)
            {
                currentString += Console.ReadLine();
                currentString += delimiter;
                result = currentString;
            }

            string removeLastChar = result.Remove(result.Length - delimiter.Length, delimiter.Length);
            Console.WriteLine($"{removeLastChar}");
        }
     }
}