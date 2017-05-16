using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0;
            int something = 0;
            bool toe = false;
            
            for (int i = 1; i <= number; i++)
            {
                while(i >0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                var sum = (total == 5) || (total == 7) || (total == 11);
                if(toe = sum)
                {
                    Console.WriteLine(${);
                }
            }
        }
    }
}
