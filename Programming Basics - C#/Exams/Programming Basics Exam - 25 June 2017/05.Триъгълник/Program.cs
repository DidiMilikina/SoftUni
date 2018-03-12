using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 4 * n + 1;
        int height = 2 * n + 1;

        Console.WriteLine(new string('#', width));

        int sideDots = 1;
        int innerSpaces = 1;

        for (int i = 0; i < n; i++)
        {
            int numberOfTags = (width - sideDots * 2 - innerSpaces) / 2;
            Console.Write(new string('.', sideDots));
            Console.Write(new string('#', numberOfTags));

            if (i == n / 2)
            {
                Console.Write($"{new string(' ', (innerSpaces - 3) / 2)}" +
                              $"(@)" +
                              $"{new string(' ', (innerSpaces - 3)/ 2)}");
            }
            else
            {
                Console.Write(new string(' ', innerSpaces));
            }

            Console.Write(new string('#', numberOfTags));
            Console.WriteLine(new string('.', sideDots));

            innerSpaces += 2;
            sideDots++;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', sideDots));
            Console.Write(new string('#', width - sideDots * 2 ));
            Console.WriteLine(new string('.', sideDots));
            sideDots++;
        }
    }
}