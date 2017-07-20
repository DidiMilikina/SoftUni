using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().Reverse().ToArray();
            Console.WriteLine(word);
        }
    }
}
