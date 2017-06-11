using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug.PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double treshold = double.Parse(Console.ReadLine());
            double last = double.Parse(Console.ReadLine());

            for (int i = 0; i < number - 1; i++)
            {
                double price = double.Parse(Console.ReadLine());
                double diff = Proc(last, price);
                bool isSignificantDifference = isDiff(diff, treshold);
                string message = Get(price, last, diff, isSignificantDifference);
                Console.WriteLine(message);

                last = price;
            }
        }

        private static string Get(double price, double last, double change, bool etherTrueOrFalse)
        {
            string result = "";
            if (change == 0)
            {
                result = string.Format("NO CHANGE: {0}", price);
            }
            else if (!etherTrueOrFalse)
            {
                result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, change * 100);
            }
            else if (etherTrueOrFalse && (change > 0))
            {
                result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, change * 100);
            }
            else if (etherTrueOrFalse && (change < 0))
                result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, change * 100);
            return result;
        }

        private static bool isDiff(double threshold, double isDiff)
        {
            if (Math.Abs(threshold) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Proc(double last, double price)
        {
            double res = (price - last) / last;
            return res;
        }
    }
}