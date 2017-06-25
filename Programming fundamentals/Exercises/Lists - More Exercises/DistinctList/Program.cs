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
              .ToArray();

            List<int> distinctElements = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentEelement = numbers[i];
                if (!distinctElements.Contains(currentEelement))
                {
                   distinctElements.Add(currentEelement);
                }   
            }
            Console.WriteLine(string.Join(" ", distinctElements));
           
            // numbers = numbers.Distinct().ToList();
           // Console.WriteLine(String.Join(" ", numbers));
        }
    }
}