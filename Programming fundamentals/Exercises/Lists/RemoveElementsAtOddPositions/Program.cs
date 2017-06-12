using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsAtOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine()
                .Split(' ')
                .ToList();
            var result = new List<string>();

            for (int i = 1; i < name.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(name[i]);
                }
            }
            Console.WriteLine(String.Join("", result));
        }
    }
}
