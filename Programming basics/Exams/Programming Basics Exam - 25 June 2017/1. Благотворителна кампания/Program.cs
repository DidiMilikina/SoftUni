using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Благотворителна_кампания
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double confectioner = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double waffles = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            double cakesSum = cakes * 45;
            double wafflesSum = waffles * 5.80;
            double pancakesSum = pancakes * 3.20;

            double pricePerDay = (cakesSum + wafflesSum + pancakesSum) * confectioner;
            double sumAllCampaign = pricePerDay * days;
            double finalSum = sumAllCampaign - (sumAllCampaign * 1 / 8);
            Console.WriteLine($"{finalSum:f2}");

        }
    }
}