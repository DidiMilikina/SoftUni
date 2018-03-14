using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < petrolPumps; i++)
            {
                var pump = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                queue.Enqueue(pump);
            }

            for (int currentStart = 0; currentStart < petrolPumps - 1; currentStart++)
            {
                int fuel = 0;

                for (int passedPumps = 0; passedPumps < petrolPumps; passedPumps++)
                {
                    var currentPump = queue.Dequeue();
                    int pumpFuel = currentPump[0];
                    int nextPump = currentPump[1];

                }
            }
        }
    }
}
