using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string nucleicAcids = "ACGT";

            for (int firstLetter = 0; firstLetter < nucleicAcids.Length; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < nucleicAcids.Length; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < nucleicAcids.Length; thirdLetter++)
                    {
                        string first = nucleicAcids[firstLetter].ToString();
                        string second = nucleicAcids[secondLetter].ToString();
                        string third = nucleicAcids[thirdLetter].ToString();

                        int sum = 0;
                        string output = first + second + third;

                        if (firstLetter + secondLetter + thirdLetter + 3 >= number)
                        {
                            Console.Write($"O{output}O ");
                        }
                        else
                        {
                            Console.Write($"X{output}X ");
                        }

                        sum++;   
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}