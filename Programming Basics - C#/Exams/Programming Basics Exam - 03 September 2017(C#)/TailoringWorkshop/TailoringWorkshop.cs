using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringWorkshop
{
    class TailoringWorkshop
    {
        static void Main(string[] args)
        {
            int numberRectangularTables = int.Parse(Console.ReadLine());
            double lengthRectangularTables = double.Parse(Console.ReadLine());
            double widthRectangularTables = double.Parse(Console.ReadLine());

            var totalAreaCover =
                numberRectangularTables * (lengthRectangularTables + 2 * 0.3)
                    * (widthRectangularTables + 2 * 0.3);

            var totalAreaSquare = numberRectangularTables * (lengthRectangularTables / 2)
                                  * (lengthRectangularTables / 2);

            var priceInDolars = totalAreaCover * 7 + totalAreaSquare * 9;
            var priceInLeva = priceInDolars * 1.85;

            Console.WriteLine($"{priceInDolars:f2} USD");
            Console.WriteLine($"{priceInLeva:f2} BGN");
        }
    }
}
