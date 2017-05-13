using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = (2 * n) - 1;
            var hight = (n / 2) / 4;

            var prazno = width - 3;
            Console.Write("@");
            Console.Write(new string(' ', prazno / 2));
            Console.Write("@");
            Console.Write(new string(' ', prazno/ 2 - 1));
            Console.WriteLine("@");

            var highth = hight - 3;
            var prazno2 = n - 3;

            Console.Write("**");
            Console.Write(new string(' ', prazno2));
            Console.Write("*");
            Console.Write(new string(' ', prazno2 - 1));
            Console.WriteLine("**");

            var prazno3 = n - 5;
            
          var pointsMid = 1;
            
            for (int i = 1; i <= n/2 - 2; i++)
            {
               
                
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string(' ', prazno3));
                Console.Write("*");
                Console.Write(new string('.', pointsMid));
                Console.Write("*");
                Console.Write(new string(' ', prazno4));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.WriteLine("*");
              pointsMid += 2;
                prazno3-=2;
                prazno4--;
               
            }
            

          

        }
    }
}
