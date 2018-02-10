using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim())
                .ToList();
            var patterns = new[] { @"@{6,10}", @"#{6,10}", @"\^{6,10}", @"\${6,10}" };

            foreach (var ticket in tickets)
            {
                int length = 0;
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var firstHalf = ticket.Substring(0, 10);
                var secondHalf = ticket.Substring(10);
                bool isMatch = false;
                string leftMatch = String.Empty;
                string rightMatch = String.Empty;

                foreach (var pattern in patterns)
                {
                    Match left = Regex.Match(firstHalf, pattern);
                    Match right = Regex.Match(secondHalf, pattern);
                    if (left.Value != String.Empty && right.Value != String.Empty)
                    {
                        leftMatch = left.Value;
                        rightMatch = right.Value;
                        length = Math.Min(left.Value.Length, right.Value.Length);
                        isMatch = true;
                        break;
                    }
                }

                if (isMatch)
                {
                    char specialSymbol = leftMatch[0];
                    char firstCharLeft = firstHalf[0];
                    bool areaAllLeftSame = firstHalf.All(c => c == firstCharLeft);

                    char firstCharRight = secondHalf[0];
                    bool areaAllRightSame = secondHalf.All(c => c == firstCharRight);

                    if (areaAllLeftSame && areaAllRightSame)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{specialSymbol} Jackpot!");

                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{specialSymbol}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }


            }
        }
    }
}
