using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var lambdaExpressions = new Dictionary<string, Dictionary<string, string>>();
            string input = Console.ReadLine();

            while (input != "lambada")
            {
                string[] inputParams = input
                    .Split(new[] { ' ', '.', '=', '>' },
                        StringSplitOptions.RemoveEmptyEntries);

                if (inputParams.Length > 1)
                {
                    string selector = inputParams[0];
                    string selectorObject = inputParams[1];
                    string property = inputParams[2];

                    if (!lambdaExpressions.ContainsKey(selector))
                    {
                        lambdaExpressions.Add(selector, new Dictionary<string, string>());
                    }
                    lambdaExpressions[selector][selectorObject] = property;
                }
                else
                {
                    lambdaExpressions = lambdaExpressions
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                          .ToDictionary(selectorObject => selectorObject.Key,
                           selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }

                input = Console.ReadLine();
            }

            foreach (var selector in lambdaExpressions)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }
        }
    }
}
