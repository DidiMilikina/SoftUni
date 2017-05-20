using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    class Program
    {
        static void Main(string[] args)
        {
            double terabytes = double.Parse(Console.ReadLine());
           
            Console.WriteLine(terabytes * 1024 * 1024 * 1024 * 1024 * 8);
        }
    }
}
