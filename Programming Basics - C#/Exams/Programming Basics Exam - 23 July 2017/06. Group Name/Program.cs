using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Group_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigLetter = char.Parse(Console.ReadLine());
            var firstLittle = char.Parse(Console.ReadLine());
            var secondLittle = char.Parse(Console.ReadLine());
            var thirdLittle = char.Parse(Console.ReadLine());
            var number = int.Parse(Console.ReadLine());

            int counter = 0;
            for (char i = 'A'; i <= bigLetter; i++)
            {
                for (char j = 'a'; j <= firstLittle; j++)
                {
                    for (char k = 'a'; k <= secondLittle; k++)
                    {
                        for (char l = 'a'; l <= thirdLittle; l++)
                        {
                            for(int m = 0; m <= number; m++)
                            {
                                counter++;
                            }
                        }
                    }   
                }
               
            }
             Console.WriteLine(counter - 1);
        }
    }
}
