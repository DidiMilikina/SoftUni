
namespace SumArrayElements
    
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int elements = int.Parse(Console.ReadLine());
            var array = new int[elements];

            for (int i = 0; i < elements; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                array[i] = currentNumber;
            }

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                var currentNumber = array[i];
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
