using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrophonTheGrumpyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] ratingsPrice = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            int entryPoints = int.Parse(Console.ReadLine());
            var typeOfItems = Console.ReadLine();
            var typeOfRatings = Console.ReadLine();
            long leftDamage = 0;
            long rightDamage = 0;

            if (typeOfItems == "cheap")
            {
                if (typeOfRatings == "positive")
                {
                    for (int i = 0; i < entryPoints; i++)
                    {
                        if (ratingsPrice[i] > 0 && ratingsPrice[i] < ratingsPrice[entryPoints])
                        {
                            leftDamage += ratingsPrice[i];

                        }
                    }
                    for (int i = entryPoints + 1; i < ratingsPrice.Length; i++)
                    {
                        if (ratingsPrice[i] > 0 && ratingsPrice[i] < ratingsPrice[entryPoints])
                        {
                            rightDamage += ratingsPrice[i];

                        }
                    }
                }

                else if (typeOfRatings == "negative")
                {
                    for (int i = 0; i < entryPoints; i++)
                    {
                        if (ratingsPrice[i] < 0 && ratingsPrice[i] < ratingsPrice[entryPoints])
                        {
                            leftDamage += ratingsPrice[i];

                        }
                    }
                    for (int i = entryPoints + 1; i < ratingsPrice.Length; i++)
                    {
                        if (ratingsPrice[i] < 0 && ratingsPrice[i] < ratingsPrice[entryPoints])
                        {
                            rightDamage += ratingsPrice[i];

                        }
                    }
                }

                else if (typeOfRatings == "all")
                {
                    for (int i = 0; i < entryPoints; i++)
                    {
                        if (ratingsPrice[i] < ratingsPrice[entryPoints])
                        {
                            leftDamage += ratingsPrice[i];

                        }
                    }
                    for (int i = entryPoints + 1; i < ratingsPrice.Length; i++)
                    {
                        if ( ratingsPrice[i] < ratingsPrice[entryPoints])
                        {
                            rightDamage += ratingsPrice[i];

                        }
                    }
                }
            }

            else if (typeOfItems == "expensive")
            {
                if (typeOfRatings == "positive")
                {
                    for (int i = 0; i < entryPoints; i++)
                    {
                        if (ratingsPrice[i] > 0 && ratingsPrice[i] >= ratingsPrice[entryPoints])
                        {
                            leftDamage += ratingsPrice[i];
                        }
                    }
                    for (int i = entryPoints + 1; i < ratingsPrice.Length; i++)
                    {
                        if (ratingsPrice[i] > 0 && ratingsPrice[i] >= ratingsPrice[entryPoints])
                        {
                            rightDamage += ratingsPrice[i];
                        }
                    }
                }
                else if (typeOfRatings == "negative")
                {
                    for (int i = 0; i < entryPoints; i++)
                    {
                        if (ratingsPrice[i] < 0 && ratingsPrice[i] >= ratingsPrice[entryPoints])
                        {
                            leftDamage += ratingsPrice[i];
                        }
                    }
                    for (int i = entryPoints + 1; i < ratingsPrice.Length; i++)
                    {
                        if (ratingsPrice[i] < 0 && ratingsPrice[i] >= ratingsPrice[entryPoints])
                        {
                            rightDamage += ratingsPrice[i];
                        }
                    }
                }
                else if (typeOfRatings == "all")
                {
                    for (int i = 0; i < entryPoints; i++)
                    {
                        if (ratingsPrice[i] >= ratingsPrice[entryPoints])
                        {
                            leftDamage += ratingsPrice[i];
                        }
                    }
                    for (int i = entryPoints + 1; i < ratingsPrice.Length; i++)
                    {
                        if (ratingsPrice[i] >= ratingsPrice[entryPoints])
                        {
                            rightDamage += ratingsPrice[i];
                        }
                    }
                }
            }

            if (leftDamage >= rightDamage)
            {
                Console.WriteLine($"Left - {leftDamage}");
            }
            else
            {
                Console.WriteLine($"Right - {rightDamage}");
            }
        }
    }
}
