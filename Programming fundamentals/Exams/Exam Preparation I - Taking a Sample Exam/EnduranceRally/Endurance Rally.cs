using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var partcipants = Console.ReadLine().Split();
            var trackIndices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            var checkpointIndices = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var partcipant in partcipants)
            {
                double fuel = partcipant[0];

                for (int currentTrackIndex = 0; currentTrackIndex <= trackIndices.Length; currentTrackIndex++)
                {
                    bool outOfFuel = fuel <= 0;
                    bool reachedEndOfTrack = currentTrackIndex == trackIndices.Length;
                    bool raceEnd = outOfFuel || reachedEndOfTrack;

                    if (raceEnd)
                    {
                        if (outOfFuel)
                        {
                            Console.WriteLine($"{partcipant} - reached {currentTrackIndex - 1}");
                        }
                        else if (reachedEndOfTrack)
                        {
                            Console.WriteLine($"{partcipant} - fuel left {fuel:f2}");
                        }
                        break;
                    }

                    var fuelAtCheckpoint = trackIndices[currentTrackIndex];
                    bool isCheckpoint = checkpointIndices.Contains(currentTrackIndex);

                    if (isCheckpoint)
                    {
                        fuel += fuelAtCheckpoint;
                    }
                    else
                    {
                        fuel -= fuelAtCheckpoint;
                    }
                }
            }
        }
    }
}
