using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMCounter
{
    class Program
    {
        static void Main(string[] args)
        {
           int beatsPerMinute = int.Parse(Console.ReadLine());
          int numberOfBeats = int.Parse(Console.ReadLine());

            var bars = (double)numberOfBeats / 4;

            var seconds = (int)(((double)numberOfBeats / beatsPerMinute) * 60) % 60;
            var minutes = numberOfBeats / beatsPerMinute;
            
                Console.WriteLine($"{Math.Round(bars,1)} bars - {minutes}m {seconds}s");
            

        }
    }
}
