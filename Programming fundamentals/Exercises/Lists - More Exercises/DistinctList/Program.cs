using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToList();

            numbers = numbers.Distinct().ToList();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}