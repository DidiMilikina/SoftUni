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
            int number = int.Parse(Console.ReadLine());

            var fileNameDict = new Dictionary<string, Dictionary<string, int>>();
            var fileExtDict = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                string[] inputParams = Console.ReadLine()
                    .Split('\\');

                string root = inputParams[0];
                string[] fileParams = inputParams[inputParams.Length - 1]
                    .Split(new[] {'.', ';'},
                        StringSplitOptions.RemoveEmptyEntries);

                string nameFiles = fileParams[0];
                string fileExtention = fileParams[1];
                int fileSize = int.Parse(inputParams[2]);

                if (!fileNameDict.ContainsKey(root))
                {
                    fileNameDict[root] = new Dictionary<string, int>();
                }
                fileNameDict[root][nameFiles] = fileSize;
                fileExtDict[nameFiles] = fileExtention;
            }

            string[] queryParams = Console.ReadLine()
                .Split(' ');

            string queryExtention = queryParams[0];
            string queryRoot = queryParams[2];

        }
    }
}
