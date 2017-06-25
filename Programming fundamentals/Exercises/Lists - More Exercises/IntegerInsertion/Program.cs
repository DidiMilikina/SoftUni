using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerInsertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string line = Console.ReadLine();

            
            while (line != "end")
            {
                int newNumbers = int.Parse(line);
                int fistDigit = line[0] - '0';
                numbers.Insert(fistDigit,newNumbers);
                line = Console.ReadLine();
                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
