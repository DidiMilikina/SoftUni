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
                line = Console.ReadLine();
                
            }
            Console.WriteLine(String.Join(" ", ));
        }
    }
}
