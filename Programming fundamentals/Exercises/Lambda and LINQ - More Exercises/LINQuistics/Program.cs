using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionInputuistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var collectionInput = new Dictionary<string, >();
            string input = Console.ReadLine();

            while (input != "exit")
            {
                string[] inputToekns = input
                    .Split(new[] { '.', '(', ')' },
                    StringSplitOptions.RemoveEmptyEntries);
                var collection = inputToekns[0];
            }
        }
    }
}