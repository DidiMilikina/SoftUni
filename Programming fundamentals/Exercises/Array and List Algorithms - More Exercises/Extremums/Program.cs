using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremums
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            var result = new List<int>();

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            int sum = 0;

            if (command == "Min")
            {
                for (int i = 0; i < number.Count; i++)
                {
                    int element = number[i];
                    string elementToString = element.ToString();

                    int count = 0;
                    while (count <= elementToString.Length)
                    {
                        if (element < minValue)
                        {
                            minValue = element;
                        }
                        elementToString = ShiftString(elementToString);
                        element = int.Parse(elementToString);
                        count++;
                    }
                    result.Add(minValue);
                    sum += minValue;
                    minValue = int.MaxValue;
                }
            }
            if (command == "Max")
            {
                for (int i = 0; i < number.Count; i++)
                {
                    int element = number[i];
                    string elementToString = element.ToString();

                    int count = 0;
                    while (count <= elementToString.Length)
                    {
                        if (element > maxValue)
                        {
                            maxValue = element;
                        }
                        elementToString = ShiftString(elementToString);
                        element = int.Parse(elementToString);
                        count++;
                    }

                    result.Add(maxValue);
                    sum += maxValue;
                    maxValue = int.MinValue;
                }
            }

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(sum);

        }
        static string ShiftString(string str)
        {
            string firstChar = str.Substring(0, 1);
            return str.Substring(1) + firstChar;
        }
    }
}