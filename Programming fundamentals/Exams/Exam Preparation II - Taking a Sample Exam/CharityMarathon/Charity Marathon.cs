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
            int lenghtMarathonInDays = int.Parse(Console.ReadLine());
            int participants = int.Parse(Console.ReadLine());
            int numberLapsEveryParticipant = int.Parse(Console.ReadLine());
            int lenghtTrack = int.Parse(Console.ReadLine());
            int capacityTrack = int.Parse(Console.ReadLine());
            double donatedMoneyPerKm = double.Parse(Console.ReadLine());

            int maxRunners = capacityTrack * lenghtMarathonInDays;
            var peopleRunning = 0.0;

            if (maxRunners > participants)
            {
                peopleRunning = participants;
            }
            else
            {
                peopleRunning = maxRunners;
            }

            var totalMeters = peopleRunning * numberLapsEveryParticipant * lenghtTrack;
            var totalKm = totalMeters / 1000;
            double moneyRaised = donatedMoneyPerKm * totalKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}