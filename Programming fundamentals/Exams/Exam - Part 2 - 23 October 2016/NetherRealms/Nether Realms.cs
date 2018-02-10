using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NetherRealms
{
    class Demon
    {
        public double Health { get; set; }
        public double Damage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] demonNames = Console.ReadLine()
                .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            var demonsResult = new Dictionary<string, Demon>();

            foreach (var demonName in demonNames)
            {
                Regex sumNumbersRegex = new Regex(@"([\-|\+])*([0-9]+\.)*[0-9]+");
                MatchCollection matchSum = sumNumbersRegex.Matches(demonName);
                double sum = 0;

                foreach (Match match in matchSum)
                {
                    double number = double.Parse(match.ToString());
                    sum += number;
                }
                
                Regex multiplyingRegex = new Regex(@"\*");
                MatchCollection matchMultiplying = multiplyingRegex.Matches(demonName);
                foreach (Match match in matchMultiplying)
                {
                    sum *= 2;
                }

                Regex dividingRegex = new Regex(@"\/");
                MatchCollection matchDividing = dividingRegex.Matches(demonName);
                foreach (Match match in matchDividing)
                {
                    sum /= 2;
                }

                int totalHealth = 0;
                Regex healthRegex = new Regex(@"[^\d\.\-\+\*\/]+");
                MatchCollection matchHealth = healthRegex.Matches(demonName);

                foreach (Match match in matchHealth)
                {
                    char[] symbols = match.ToString().ToCharArray();
                    foreach (char symbol in symbols)
                    {
                        int number = symbol;
                        totalHealth += number;
                    }
                }

                Demon participant = new Demon();
                {
                    participant.Damage = sum;
                    participant.Health = totalHealth;
                }
                demonsResult.Add(demonName, participant);
            }

            var orderedDemons = demonsResult
                .OrderBy(x => x.Key);

            foreach (var demon in orderedDemons)
            {
                var demonNameResult = demon.Key;
                var demonHealthResult = demon.Value.Health;
                var demonDamageResult = demon.Value.Damage;

                Console.WriteLine($"{demonNameResult} - {demonHealthResult} health, {demonDamageResult:f2} damage");
            }
        }
    }
}
