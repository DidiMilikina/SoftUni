using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = int.Parse(Console.ReadLine());
            var letters = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbers; i++)
            {
                for (int j = 1; j <= numbers; j++)
                {
                    for (var k = 'a'; k < 'a' + letters; k++)
                    {
                        for (var l = 'a'; l < 'a' + letters; l++)
                        {
                            for (int m = 1; m <= numbers; m++)
                            {
                                if (m > i && m > j)
                                {
                                    Console.Write($"{i}{j}{k}{l}{m} ");
                                }

                            }
                        }
                    }
                }
            }
           
        }
  
    }
}
