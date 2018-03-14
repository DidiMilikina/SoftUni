using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstElement = long.Parse(Console.ReadLine());

            Queue<long> temporaryQueue = new Queue<long>();
            Queue<long> queueToPrint = new Queue<long>();

            temporaryQueue.Enqueue(firstElement);

            while (queueToPrint.Count < 50)
            {
                temporaryQueue.Enqueue(temporaryQueue.Peek() + 1);
                temporaryQueue.Enqueue(2 * temporaryQueue.Peek() + 1);
                temporaryQueue.Enqueue(temporaryQueue.Peek() + 2);
                queueToPrint.Enqueue(temporaryQueue.Dequeue());
            }

            Console.WriteLine(string.Join(" ", queueToPrint));
        }
    }
}
