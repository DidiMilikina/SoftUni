using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] childerInput = Console.ReadLine().Split(' ');
            int tossLimit = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(childerInput);

            while (queue.Count != 1)
            {
                for (int tossCountIndex = 1; tossCountIndex < tossLimit; tossCountIndex++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
