using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Болница
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var doctors = 7;
            var treatedPatients = 0;
            var untreatedPatients = 0;
       
            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }

                var currentPatients = int.Parse(Console.ReadLine());
                if (doctors >= currentPatients)
                {
                    treatedPatients += currentPatients;
                }
                else
                {
                    treatedPatients += doctors;
                    currentPatients -= doctors;
                    untreatedPatients += currentPatients;   
                }
            }
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
