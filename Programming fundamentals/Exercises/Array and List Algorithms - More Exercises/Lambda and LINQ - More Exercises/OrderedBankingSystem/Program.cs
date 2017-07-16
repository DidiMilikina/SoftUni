using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedBankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var banksAndAccounts = new Dictionary<string, Dictionary<string, decimal>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input
                    .Split(new[] {' ', '-', '>'}
                        , StringSplitOptions.RemoveEmptyEntries);
                string bankName = inputParams[0];
                string bankAccountName = inputParams[1];
                decimal bankAccountBalance = decimal.Parse(inputParams[2]);

                if (!banksAndAccounts.ContainsKey(bankName))
                {
                    banksAndAccounts.Add(bankName, new Dictionary<string, decimal>());
                }
                if (!banksAndAccounts[bankName].ContainsKey(bankAccountName))
                {
                    banksAndAccounts[bankName].Add(bankAccountName, 0);
                }
                banksAndAccounts[bankName][bankAccountName] += bankAccountBalance;
                input = Console.ReadLine();
            }
            foreach (var bank in banksAndAccounts.OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value)))
            {
                foreach (var account in bank.Value.OrderByDescending(account => account.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
                }
            }
        }
    }
}
