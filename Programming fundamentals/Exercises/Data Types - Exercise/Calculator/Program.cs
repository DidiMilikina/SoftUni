using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            if(operation == "+")
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber + secondNumber}");
            }
            else if(operation == "-")
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber - secondNumber}");
            }
            else if(operation == "*")
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber * secondNumber}");
            }
            else
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {firstNumber / secondNumber}");
            }
        }
    }
}
