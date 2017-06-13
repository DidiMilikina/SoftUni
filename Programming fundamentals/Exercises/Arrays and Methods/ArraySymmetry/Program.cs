using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            bool isSymmetric = true;
            for (int i = 0; i < words.Length / 2; i++)
            {
                if (words[i] != words[words.Length - 1 - i])
                {
                    isSymmetric = false;
                    break;  
                }
            }

            if (isSymmetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
