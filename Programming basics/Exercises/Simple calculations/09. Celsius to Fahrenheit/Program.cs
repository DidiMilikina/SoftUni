using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalCelsius = double.Parse(Console.ReadLine());
            var originalFahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine(originalCelsius);
            Console.WriteLine(originalFahrenheit);
            Console.Write("Enter Temperature (Farenheit): ");

            var fahrenheitToCelsius = ((originalCelsius / 5) * 9) + 32;
            var celsiusToFahrenheit = ((originalFahrenheit - 32) / 9) * 5;
            
            Console.WriteLine("originalCelsius = :" + originalCelsius);
            Console.WriteLine("celsiusToFahrenheit = :" + celsiusToFahrenheit);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(fahrenheit);

        }
    }
}