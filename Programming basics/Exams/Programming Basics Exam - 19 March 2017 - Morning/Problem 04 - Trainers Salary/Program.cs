using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Trainers_Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            var lectures = double.Parse(Console.ReadLine());
            var budget = double.Parse(Console.ReadLine());
            var oneLection = budget / lectures;

            int numJelev = 0;
            int numRoYaL = 0;
            int numRoli = 0;
            int numTrofon = 0;
            int numSino = 0;
            int numOthers = 0;

            for (int i = 1; i <= lectures; i++)
            {
                string lektor = Console.ReadLine();
                if (lektor == "Jelev") numJelev++;
                if (lektor == "RoYaL") numRoYaL++;
                if (lektor == "Roli") numRoli++;
                if (lektor == "Trofon") numTrofon++;
                if (lektor == "Sino") numSino++;
                if (lektor != "Jelev" && lektor != "RoYaL" && lektor != "Roli" && lektor != "Trofon" && lektor != "Sino") numOthers++;
            }

            Console.WriteLine($"Jelev salary: {numJelev * oneLection:f2} lv");
            Console.WriteLine($"RoYaL salary: {numRoYaL * oneLection:f2} lv");
            Console.WriteLine($"Roli salary: {numRoli * oneLection:f2} lv");
            Console.WriteLine($"Trofon salary: {numTrofon * oneLection:f2} lv");
            Console.WriteLine($"Sino salary: {numSino * oneLection:f2} lv");
            Console.WriteLine($"Others salary: {numOthers * oneLection:f2} lv");
        }
    }
}
