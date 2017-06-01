using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHelath = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|", 
                new string('|', currentHelath),
                new string('.', maxHealth - currentHelath));
            Console.WriteLine("Energy: |{0}{1}|",
                new string('|', currentEnergy),
                new string('.', maxEnergy - currentEnergy));
            
        }
    }
}
