using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfValue = Console.ReadLine();

            switch (typeOfValue)
            {
                case "int":
                    {
                        var int1 = int.Parse(Console.ReadLine());
                        var int2 = int.Parse(Console.ReadLine());

                        var greater = Max(int1, int2);
                        Console.WriteLine(greater);
                        break;
                    }
                case "char":
                    {
                        var char1 = char.Parse(Console.ReadLine());
                        var char2 = char.Parse(Console.ReadLine());

                        var greater = Max(char1, char2);
                        Console.WriteLine(greater);
                        break;
                    }

                case "string":
                    {
                        var string1 = Console.ReadLine();
                        var string2 = Console.ReadLine();

                        var greater = Max(string1, string2);
                        Console.WriteLine(greater);
                        break;
                    }
            }
        }
        static int Max(int int1, int int2)
        {
            if(int1 > int2)
            {
                return int1;
            }
            else
            {
                return int2;
            }
        }

        static char Max(char char1, char char2)
        {
            if(char1 > char2)
            {
                return char1;
            }
            else
            {
                return char2;
            }
        }

        static string Max(string string1, string string2)
        {
            if(string1.CompareTo(string2) >= 0)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }
    } 
}
