using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {

            double marathonDays = double.Parse(Console.ReadLine());
            double numberParticipants = double.Parse(Console.ReadLine());
            double averageNumberLapsPerOne = double.Parse(Console.ReadLine());
            double lenghtTrack = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double moneyDonatedPerKm = double.Parse(Console.ReadLine());

            var totalKm = 0.0;
            if (capacity * marathonDays >= numberParticipants)
            {
                totalKm = numberParticipants * averageNumberLapsPerOne * lenghtTrack / 1000;
            }
            else
            {
                totalKm = capacity * marathonDays * averageNumberLapsPerOne * lenghtTrack / 1000;
            }
            var donation = totalKm * moneyDonatedPerKm;
            Console.WriteLine($"Money raised: {donation:f2}");
        }
    }
}
