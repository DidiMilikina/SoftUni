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
            var filesExt = new Dictionary<string, string>();

            for (int i = 0; i < numberFiles; i++)
            {
                string[] tokens = Console.ReadLine()
                   .Split(new[] { '\\' });

                string root = tokens[0];
                string[] fileTokens = tokens[tokens.Length - 1].Split(';');
                string fileNameExt = fileTokens[0];
                long size = long.Parse(fileTokens[1]);
                string fileName = fileNameExt;
                string fileExt = fileNameExt
                    .Split('.')[fileNameExt.Split('.').Length - 1];         

                if (!data.ContainsKey(root))
                {
                    data[root] = new Dictionary<string, long>();
                }
                data[root][fileName] = size;
                filesExt[fileName] = fileExt;
            }

            string[] findFile = Console.ReadLine().Split();
            string queryExtension = findFile[0];
            string queryRoot = findFile[2];

            var extractedFiles = new Dictionary<string, long>();
            if (data.ContainsKey(queryRoot))
            {
                foreach (var file in data[queryRoot])
                {
                    string fileName = file.Key;
                    long fileSize = file.Value;

                    if (filesExt[fileName] == queryExtension)
                    {
                        extractedFiles.Add(fileName, fileSize);
                    }
                }
            }

            if (extractedFiles.Count > 0)
            {
                var sortedFiles = extractedFiles
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key);

                foreach (var file in sortedFiles)
                {
                    string nameWithExt = file.Key;
                    long fileSize = file.Value;
                    Console.WriteLine($"{nameWithExt} - {fileSize} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
