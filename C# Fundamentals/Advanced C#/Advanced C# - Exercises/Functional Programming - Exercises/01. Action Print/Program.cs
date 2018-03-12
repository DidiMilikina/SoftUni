using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Action_Print
{
    public class ActionPrintExercise
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            Action<string> print = str => Console.WriteLine(str);
            PrintAllNames(input, print);
        }

        private static void PrintAllNames(string[] input, Action<string> print)
        {
            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}
