using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayData
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            double averageNums = numbers.Average();
            numbers.RemoveAll(n => n < averageNums);

            if (command == "Min")
            {
                Console.WriteLine(numbers.Min());
            }
            else if (command == "Max")
            {
                Console.WriteLine(numbers.Max());
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.OrderBy(n => n)));
            }
        }
    }
}
