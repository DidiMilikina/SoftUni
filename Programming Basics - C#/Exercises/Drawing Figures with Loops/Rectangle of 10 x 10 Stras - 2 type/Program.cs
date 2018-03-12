using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_10_x_10_Stras___2_type
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var row = 0; row < 10; row++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}
