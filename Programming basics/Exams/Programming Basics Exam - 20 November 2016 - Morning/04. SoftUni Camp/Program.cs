using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfGroups = int.Parse(Console.ReadLine());
            var allPeople = 0.0;
            var peopleGroupInCar = 0.0; // double peopleGroupInCar = 0;
            var peopleInGroupInMicrobus = 0.0;
            var peopleInGroupInLittleBus = 0.0;
            var peopleInGroupInBigBus = 0.0;
            var peopleInGroupInTrain = 0.0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                var people = int.Parse(Console.ReadLine());
                allPeople += people;
                
                if (people <= 5)
                {
                    peopleGroupInCar += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    peopleInGroupInMicrobus += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    peopleInGroupInLittleBus += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    peopleInGroupInBigBus += people;
                }
                else
                {
                    peopleInGroupInTrain += people;
                }
            }

            var p1 = peopleGroupInCar / allPeople * 100;
            var p2 = peopleInGroupInMicrobus / allPeople * 100;
            var p3 = peopleInGroupInLittleBus / allPeople * 100;
            var p4 = peopleInGroupInBigBus / allPeople * 100;
            var p5 = peopleInGroupInTrain / allPeople * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
