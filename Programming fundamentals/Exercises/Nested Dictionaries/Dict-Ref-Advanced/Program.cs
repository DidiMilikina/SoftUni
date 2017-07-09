using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameAndValue =
                new Dictionary<string, List<int>>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] tokens =
                    input.Split(new string[] { " -> " },
                        StringSplitOptions.RemoveEmptyEntries);

                string name = tokens[0];

                if (IsName(tokens[1]))
                {
                    string otherName = tokens[1];

                    if (nameAndValue.ContainsKey(otherName))
                    {
                        List<int> otherNumbers =
                            nameAndValue[otherName];

                        if (!nameAndValue.ContainsKey(name))
                        {
                            nameAndValue.Add(name, new List<int>());
                        }

                        nameAndValue[name].Clear();
                        nameAndValue[name].AddRange(otherNumbers);
                    }
                }
                else
                {
                    int[] numbers = tokens[1]
                        .Split(new string[] { ", " },
                            StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    if (!nameAndValue.ContainsKey(name))
                    {
                        nameAndValue.Add(name, new List<int>());
                    }

                    nameAndValue[name].AddRange(numbers);
                }

                input = Console.ReadLine();
            }

            foreach (var record in nameAndValue)
            {
                string name = record.Key;
                List<int> numbers = record.Value;

                Console.WriteLine("{0} === {1}",
                    name,
                    string.Join(", ", numbers));
            }
        }

        static bool IsName(string input)
        {
            foreach (char ch in input)
            {
                if (char.IsLetter(ch))
                {
                    return true;
                }
            }

            return false;
        }
    }
}