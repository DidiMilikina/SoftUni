using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Сбор_или_Произведение
{
    class Program
    {
        static void Main(string[] args)
        {

            int controlNum = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 1; i <= 30; i++)
            {
                for (int j = 1; j <= 30; j++)
                {
                    for (int k = 1; k <= 30; k++)
                    {
                        if (i * j * k == controlNum)
                        {
                            if ((i > j) && (j > k))
                            {
                                Console.WriteLine($"{i} * {j} * {k} = {controlNum}");
                                counter++;
                            }
                        }

                        if (i + j + k == controlNum)
                        {
                            if ((i < j) && (j < k))
                            {
                                Console.WriteLine($"{i} + {j} + {k} = {controlNum}");
                                counter++;
                            }
                        }
                    }
                }

            }
            if (counter == 0)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
