using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
         
            if (number1 < 100)
            { Console.WriteLine("Less than 100"); }
            else if (100 <= number1 && number1 <= 200)
            { Console.WriteLine("Between 100 and 200"); }
            else if (number1 > 200)
            { Console.WriteLine("Greater than 200"); }
          

        }
    }
}
