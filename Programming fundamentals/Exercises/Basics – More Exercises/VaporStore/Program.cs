using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalans = double.Parse(Console.ReadLine());
            string nameGame = Console.ReadLine();

            double outFall = 39.99;
            double csOG = 15.99;
            double zplinter = 19.99;
            double honored = 59.99;
            double roverWatch = 29.99;
            double roverWatchOrigins = 39.99;
            double startingMoney = currentBalans;

            while (nameGame != "Game Time")
            {
                string currentGame = " ";
                double price = 0;

                if (nameGame == "OutFall 4")
                {
                    currentGame = "OutFall 4";
                    price = outFall;

                }
                else if(nameGame == "CS: OG")
                {
                    currentGame = "CS: OG";
                    price = csOG;
                }
                else if(nameGame == "Zplinter Zell")
                {
                    currentGame = "Zplinter Zell";
                    price = zplinter;
                        
                }
                else if(nameGame == "Honored 2")
                {
                    currentGame = "Honored 2";
                    price = honored;
                }
                else if(nameGame == "RoverWatch")
                {
                    currentGame = "RoverWatch";
                    price = roverWatch;
                }
                else if(nameGame == "RoverWatch Origins Edition")
                {
                    currentGame = "RoverWatch Origins Edition";
                    price = roverWatchOrigins;
                }

                else
                {
                    Console.WriteLine("Not Found");
                    nameGame = Console.ReadLine();
                    continue;
                }

                if (price <= currentBalans)
                {
                    Console.WriteLine($"Bought {currentGame}");
                    currentBalans -= price;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
               
                if(currentBalans <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                nameGame = Console.ReadLine();
            }

            

            Console.Write($"Total spent: ${(startingMoney - currentBalans):f2}. ");
            Console.WriteLine($"Remaining: ${currentBalans:f2}");
           
        }
    }
}
