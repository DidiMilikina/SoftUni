using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(' ');
            Action<string> addPrefix = str => Console.WriteLine("Sir " + str);
            PrintAllNamesWithPrefix(names, addPrefix);
        }

        private static void PrintAllNamesWithPrefix(string[] names, Action<string> addPrefix)
        {
            foreach (var name in names)
            {
                addPrefix(name);
            }
        }
    }
}
