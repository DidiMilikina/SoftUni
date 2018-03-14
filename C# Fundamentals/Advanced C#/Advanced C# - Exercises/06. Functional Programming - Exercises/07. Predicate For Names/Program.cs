using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLenght = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            PrintNames(names, n => n.Length <= nameLenght);
        }

        private static void PrintNames(IEnumerable<string> names, Func<string, bool> filter)
        {
            Console.WriteLine(string.Join(Environment.NewLine, names.Where(filter)));   
        }
    }
}
