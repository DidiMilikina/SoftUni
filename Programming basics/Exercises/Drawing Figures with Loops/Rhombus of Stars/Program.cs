using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            #region first part 
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
                #endregion


                #region second part
                for (int row = n - 1; row >= 1; row--)
                {
                    Console.Write(new string(' ', n - row));
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }
 
                    #endregion

                }
                
            }
           
        }
