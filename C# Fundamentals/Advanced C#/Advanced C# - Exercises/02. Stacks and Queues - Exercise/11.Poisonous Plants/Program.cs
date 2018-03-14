using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPlants = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            int[] days = new int[numberPlants];

            Stack<int> stack = new Stack<int>();      

            for (int i = 0; i < numberPlants; i++)
            {
                int maxDays = 0;

                while (stack.Count > 0 && plants[stack.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[stack.Pop()]);
                }
                if (stack.Count > 0)
                {
                    days[i] = maxDays + 1;
                }
                stack.Push(i);
            }
            Console.WriteLine(days.Max());
        }
    }
}
