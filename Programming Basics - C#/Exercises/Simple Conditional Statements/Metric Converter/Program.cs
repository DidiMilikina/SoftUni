using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputMetric = double.Parse(Console.ReadLine());
            var inputNumber = Console.ReadLine();
            var outputMetric = Console.ReadLine();
            var intermediateMeters = 0.0;

            
            #region Input
            if (inputNumber == "mm")
            {intermediateMeters = inputMetric / 1000;}
            else if (inputNumber == "cm")
            {intermediateMeters = inputMetric / 100;}
            else if (inputNumber == "mi")
            {intermediateMeters = inputMetric / 0.000621371192;}
            else if (inputNumber == "in")
            {intermediateMeters = inputMetric / 39.3700787;}
            else if (inputNumber == "km")
            {intermediateMeters = inputMetric / 0.001;}
            else if (inputNumber == "ft")
            {intermediateMeters = inputMetric / 3.2808399;}
            else if (inputNumber == "yd")
            {intermediateMeters = inputMetric / 1.0936133;}
            else if (inputNumber == "m")
            { intermediateMeters = inputMetric; }

            #endregion

           var finalNumber = 0.0;

            #region Output
            if (outputMetric == "mm")
            {finalNumber = intermediateMeters * 1000;}
            else if (outputMetric == "cm")
            {finalNumber = intermediateMeters * 100;}
            else if (outputMetric == "mi")
            {finalNumber = intermediateMeters * 0.000621371192;}
            else if (outputMetric == "in")
            {finalNumber = intermediateMeters * 39.3700787;}
            else if (outputMetric == "km")
            {finalNumber = intermediateMeters * 0.001;}
            else if (outputMetric == "ft")
            {finalNumber = intermediateMeters * 3.2808399;}
            else if (outputMetric == "yd")
            {finalNumber = intermediateMeters * 1.0936133;}
            else if (outputMetric == "m")
            {finalNumber = intermediateMeters; }
            #endregion

            Console.WriteLine($"{finalNumber} {outputMetric}");
        }
    }
}