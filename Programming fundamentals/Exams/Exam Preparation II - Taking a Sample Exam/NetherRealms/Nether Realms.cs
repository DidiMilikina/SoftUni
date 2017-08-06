using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
            var regex = new Regex(@"-?\d+\.?\d*");
            var result = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
                var healthSymbols = demon.Where(s =>
                    !char.IsDigit(s) &&
                    s != '+' &&
                    s != '-' &&
                    s != '*' &&
                    s != '/' &&
                    s != '.');

                var health = 0;
                foreach (var healthSymbol in healthSymbols)
                {
                    health += healthSymbol;
                }

                var matches = regex.Matches(demon);
                var damage = 0.0;

                foreach (Match match in matches)
                {
                    var currentNumber = double.Parse(match.Value);
                    damage += currentNumber;
                }

                var modifiers = demon.Where(s => s == '*' || s == '/');
                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                result.Add(demon, new Demon
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                });
            }

            foreach (var demonKVP in result)
            {
                var demon = demonKVP.Value;
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage ");
            }
        }
    }
}
