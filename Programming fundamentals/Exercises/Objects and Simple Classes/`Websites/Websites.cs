using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class Websites
    {
        class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Queries { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dataBase = new List<Website>();

            while (input != "end")
            {
                string[] inputParams = input
                    .Split(new[] {" | ", ","},
                        StringSplitOptions.RemoveEmptyEntries);
                var site = new Website();
                site.Host = inputParams[0];
                site.Domain = inputParams[1];
                site.Queries = inputParams.Skip(2).ToList();

                dataBase.Add(site);

                input = Console.ReadLine();
            }
            foreach (var sites in dataBase)
            {
                if(sites.Queries.Count != 0)
                {

                    Console.WriteLine($"https://www.{sites.Host}.{sites.Domain}/query?=[{string.Join("]&[", sites.Queries)}]");
                    continue;
                }
                else
                {
                    Console.WriteLine($"https://www.{sites.Host}.{sites.Domain}");
                }
            }
        }
    }
}
