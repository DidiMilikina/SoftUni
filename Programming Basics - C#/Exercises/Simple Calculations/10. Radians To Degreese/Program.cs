﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Radians_To_Degreese
{
    class Program
    {
        static void Main(string[] args)
        {
             var rad = double.Parse(Console.ReadLine());
                var deg = rad * 180 / Math.PI;

                Console.WriteLine("{0:f2}", deg);
            }
        }
    }
