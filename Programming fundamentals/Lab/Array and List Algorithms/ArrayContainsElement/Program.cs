using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayContainsElement
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numbersArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var element = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] == element)
                {
                    isFound = true;
                    break;                    
                }
            }

            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
