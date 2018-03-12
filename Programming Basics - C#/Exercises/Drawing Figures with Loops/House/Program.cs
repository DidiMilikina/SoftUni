using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            #region roof of house
            var numberOfRows = n / 2 + n % 2;
            var numberOfStars = 0;
            if (n % 2 == 0)
            {
                numberOfStars = 2;
            }
            else
            {
                numberOfStars = 1;
            }

            for (int i = 0; i < numberOfRows; i++)
            {
                var numberOfDashes = (n - numberOfStars) / 2;
                Console.Write(new string('-', numberOfDashes));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', numberOfDashes));

                numberOfStars += 2;
            }
            #endregion

            #region body of house
            numberOfRows = n / 2;
            for (int row = 0; row < numberOfRows; row++)
            {
                Console.Write('|');
                Console.Write(new string('*', n -2));
                Console.WriteLine('|');
            }
            #endregion
        }
    }
}
