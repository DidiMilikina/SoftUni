using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Cat_Lady
{
    class Program
    {
        static void Main(string[] args)
        {
            var cats = new List<Cat>();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var catInfo = command.Split();
                var breed = catInfo[0];
                var name = catInfo[1];
                var property = double.Parse(catInfo[2]);

                var cat = new Cat(breed, name);

                if (breed.Equals("StreetExtraordinaire"))
                {
                    cat.Decibels = property;
                }
                else if (breed.Equals("Siamese"))
                {
                    cat.EarSize = property;
                }
                else
                {
                    cat.FurLength = property;
                }

                cats.Add(cat);
                command = Console.ReadLine();
            }

            var catName = Console.ReadLine();
            var catResult = cats.FirstOrDefault(c => c.Name.Equals(catName));

            Console.WriteLine(catResult);
        }
    }
}
