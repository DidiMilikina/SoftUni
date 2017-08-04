using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#$^])\1{5,}";
            var regex = new Regex(pattern);
            var tickets = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                //From beggining to half.
                var leftSide = ticket.Substring(0, ticket.Length / 2);
                //Other half
                var rightSide = ticket.Substring(ticket.Length / 2);

                var leftMatch = regex.Match(leftSide);
                var rightMatch = regex.Match(rightSide);

                if (leftMatch.Success && rightMatch.Success)
                {
                    var symbol = leftMatch.Value[0];
                    var shorterMatch = Math.Min(leftMatch.Length, rightMatch.Length);
                    var jackpot = string.Empty;

                    if (shorterMatch == 10)
                    {
                        jackpot = " Jackpot!";
                    }
                    Console.WriteLine($"ticket \"{ticket}\" - {shorterMatch}{symbol}{jackpot}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
