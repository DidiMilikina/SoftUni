using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse);
            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        input = ForEach(input, n => n + 1);
                        break;
                    case "multiply":
                        input = ForEach(input, n => n * 2);
                        break;
                    case "subtract":
                        input = ForEach(input, n => n - 1);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", input));
                        break;
                }
                command = Console.ReadLine();
            }

        }
        public static IEnumerable<int> ForEach(IEnumerable<int> collection, Func<int, int> func)
        {
            return collection.Select(n => func(n));
        }
    }
}
