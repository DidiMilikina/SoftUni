using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '},
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                .ToList();

            while (numbers.Count >= 1)
            {
                var indexNumber = Console.ReadLine();
                if (indexNumber < 0)
                {
                    
                }
            }
        }
    }
}
