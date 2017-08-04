using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, Dictionary<string, long>>();

            int numFiles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numFiles; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new [] { '\\' }, 
                    StringSplitOptions.RemoveEmptyEntries);
                string[] filenameSize = input[input.Length - 1]
                    .Split(new [] { ';' }, 
                    StringSplitOptions.RemoveEmptyEntries);

                string root = input[0];
                string filenameExtension = filenameSize[0];
                long size = long.Parse(filenameSize[1]);

                if (!result.ContainsKey(root))
                {
                    result[root] = new Dictionary<string, long>();
                }
                else
                {
                    result[root][filenameExtension] = size;
                }
            }

            string[] query = Console.ReadLine().Split();
        }
    }
}
