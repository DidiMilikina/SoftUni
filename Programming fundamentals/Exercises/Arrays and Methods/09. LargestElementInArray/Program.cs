using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LargestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            
            for (int i = 0; i < x; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int max = arr.Max();
            
            Console.WriteLine(max);
        }
    }
}
