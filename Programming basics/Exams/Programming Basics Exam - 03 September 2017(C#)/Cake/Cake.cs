using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Cake
    {
        static void Main(string[] args)
        {
            int widthCake = int.Parse(Console.ReadLine());
            int lengthCake = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int leftPieces = widthCake * lengthCake;
            int takeCakePieces = 0;

            while (!command.Equals("STOP"))
            {
                takeCakePieces = int.Parse(command);

                if (takeCakePieces > leftPieces)
                {
                    break;
                }
                else
                {
                    leftPieces = leftPieces - takeCakePieces;
                }

                command = Console.ReadLine();
            }

            if (takeCakePieces > leftPieces)
            {
                int needMorePieces = takeCakePieces - leftPieces;
                Console.WriteLine($"No more cake left! You need {needMorePieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{leftPieces} pieces are left.");
            }
        }
    }
}
