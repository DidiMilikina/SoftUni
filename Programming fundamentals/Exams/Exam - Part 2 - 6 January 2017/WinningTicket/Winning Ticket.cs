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
            var tickets = Console.ReadLine().Split(',').Select(t => t.Trim()).ToList();
            var patterns = new string[] {@"@{6,10}", @"#{6,10}", @"\^{6,10}", @"\${6,10}"};
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var firstHalf = ticket.Substring(0, 10);
                var secondHalf = ticket.Substring(10);

                foreach (var pattern in patterns)
                {
                    Match left = Regex.Match(firstHalf, pattern);
                    Match right = Regex.Match(secondHalf, pattern);


                }
            }
        }
    }
}
