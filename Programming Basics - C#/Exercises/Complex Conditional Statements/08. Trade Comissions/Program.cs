﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var commissions = -1.0;

            if (city == "sofia")
            {
                if (0 <= sales && sales <= 500) commissions = 0.05;
                else if (500 <= sales && sales <= 1000) commissions = 0.07;
                else if (1000 <= sales && sales <= 10000) commissions = 0.08;
                else if (sales > 10000) commissions = 0.12;

            }
            if (city == "varna")
            {
                if (0 <= sales && sales <= 500) commissions = 0.045;
                else if (500 <= sales && sales <= 1000) commissions = 0.075;
                else if (1000 <= sales && sales <= 10000) commissions = 0.10;
                else if (sales > 10000) commissions = 0.13;
            }
            if (city == "plovdiv")
            {
                if (0 <= sales && sales <= 500) commissions = 0.055;
                else if (500 <= sales && sales <= 1000) commissions = 0.08;
                else if (1000 <= sales && sales <= 10000) commissions = 0.12;
                else if (sales > 10000) commissions = 0.145;
            }
            if (commissions == -1)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}", commissions * sales);
            }
        }
   }
}