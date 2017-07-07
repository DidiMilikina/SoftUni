using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}