using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingCrisis
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int number = int.Parse(Console.ReadLine());
            List<int> result = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int insertPosition = 0;

            for (int i = 0; i < number - 1; i++)
            {
                List<int> sequenceToAdd = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int j = 0; j < result.Count; j++)
                {
                    if (sequenceToAdd[0] >= result[j])
                    {
                        insertPosition = j + 1;
                    }
                }

                for (int k = 0; k < sequenceToAdd.Count; k++)
                {
                    result.Insert(insertPosition + k, sequenceToAdd[k]);
                    if (insertPosition + k != result.Count - 1)
                    {
                        if (sequenceToAdd[k] > result[insertPosition + k + 1])
                        {
                            break;
                        }
                    }

                }

                int removePosition = 0;
                bool toRemove = false;

                for (int j = 1; j < result.Count; j++)
                {
                    if (result[j] < result[j - 1])
                    {
                        for (int o = j; o < result.Count; o++)
                        {
                            result.RemoveAt(o);
                            o--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}