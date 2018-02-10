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
            var didimonRegex = new Regex(@"[^a-zA-Z\-]+");
            var bojomonRegex = new Regex(@"[a-zA-Z]+\-[a-zA-Z]+");

            while (true)
            {
                #region DidiTurn
                if (!didimonRegex.IsMatch(input))
                {
                    break;
                }
                var didiMatch = didimonRegex.Match(input);
                Console.WriteLine(didiMatch.Value);
                input = input.Substring(didiMatch.Index + didiMatch.Value.Length);
                #endregion
            

                #region BojoTurn
                if (!bojomonRegex.IsMatch(input))
                {
                    break;
                }
                var bojoMatch = bojomonRegex.Match(input);
                Console.WriteLine(bojoMatch.Value);
                input = input.Substring(bojoMatch.Index + bojoMatch.Value.Length);
                #endregion
            }
        }
    }
}
