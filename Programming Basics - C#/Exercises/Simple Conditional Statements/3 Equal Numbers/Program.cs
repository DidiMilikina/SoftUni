
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var word1 = (Console.ReadLine().ToLower());
            var word2 = (Console.ReadLine().ToLower());
            var word3 = (Console.ReadLine().ToLower());

            if (word2 == word1)
            { Console.WriteLine("yes"); }
            else 
            { Console.WriteLine("no"); }
         
        }
    }
}