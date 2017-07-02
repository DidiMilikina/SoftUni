using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string inputLine = Console.ReadLine();

            int lastShotNumber = 0;

            while (true)
            {
                if (inputLine == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was " + lastShotNumber);
                        break;
                    }

                    double average = numbers.Average();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= average)
                        {
                            lastShotNumber = numbers[i];
                            numbers.RemoveAt(i);
                            Console.WriteLine("shot " + lastShotNumber);
                            break;
                        }
                    }

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }
                else if (inputLine == "stop")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("you shot them all. last one was " + lastShotNumber);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
                        break;
                    }
                }
                else
                {
                    int number = int.Parse(inputLine);
                    numbers.Insert(0, number);
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}