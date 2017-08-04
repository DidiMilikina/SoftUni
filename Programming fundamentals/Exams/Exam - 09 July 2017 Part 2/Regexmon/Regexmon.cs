using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var didimonRegex = new Regex(@"[^a-zA-Z\-]");
            var bojomonRegex = new Regex(@"[a-zA-Z\-]");

           
        }
    }
}
