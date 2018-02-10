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
                .Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)        
                    .ToList();

            var sum = 0;
            var checkNumber = 0;

            while (numbers.Count >= 1)
            {
                var indexNumber = int.Parse(Console.ReadLine());

                if (numbers.Count == 1)
                {
                    sum += numbers[0];
                    break;
                }
                if (indexNumber < 0)
                {
                    sum += numbers[0];
                    checkNumber = numbers[0];
                    numbers[0] = numbers[numbers.Count - 1];
                }
              
                else if (indexNumber >= numbers.Count)
                {
                    sum += numbers[numbers.Count - 1];
                    checkNumber = numbers[numbers.Count - 1];
                    numbers[numbers.Count - 1] = numbers[0];
                }

                else if (indexNumber >= 0 || indexNumber <= numbers.Count - 1)
                {
                    sum += numbers[indexNumber];
                    checkNumber = numbers[indexNumber];
                    numbers.RemoveAt(indexNumber);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] <= checkNumber)
                    {
                        numbers[i] += checkNumber;
                    }
                    else
                    {
                        numbers[i] -= checkNumber;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
