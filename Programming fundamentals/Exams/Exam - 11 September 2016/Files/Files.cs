using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Files
    {
        static void Main(string[] args)
        {
            var numberFiles = int.Parse(Console.ReadLine());
            var data = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < numberFiles; i++)
            {
                var root = Console.ReadLine()
                    .Split(new[] { '\\', ';' });
                var mainRoot = root[0];
                var file = root[root.Length - 2];
                var size = long.Parse(root[root.Length - 1]);

                if (!data.ContainsKey(mainRoot))
                {
                    data[mainRoot] = new Dictionary<string, long>();
                }
                if (!data[mainRoot].ContainsKey(file))
                {
                    data[mainRoot][file] = new long();
                }
            }

            var findFile = Console.ReadLine().Split();
            var extentionFile = findFile[0];
            var roott = findFile[2];
        }
    }
}
