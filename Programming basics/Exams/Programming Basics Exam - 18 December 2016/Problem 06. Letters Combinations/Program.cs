using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = char.Parse(Console.ReadLine().ToLower());
            int b = char.Parse(Console.ReadLine().ToLower());
            int c = char.Parse(Console.ReadLine().ToLower());
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i == c)
                {
                    continue;
                }
                for (int j = a; j <= b; j++)
                {
                    if (j == c)
                    {
                        continue;
                    }
                    for (int l = a; l <= b; l++)
                    {
                        if (l == c)
                        {
                            continue;
                        }
                        count++;
                        Console.Write("{0}{1}{2} ", (char)(i), (char)(j), (char)(l));
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
