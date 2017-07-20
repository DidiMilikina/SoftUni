using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizedBankingSystem
{
    class Program
    {
        class BankAccount
        {
            public string Name { get; set; }
            public string Bank { get; set; }
            public decimal Balance { get; set; }

        }
        static void Main(string[] args)
        {
            var bankNameBalance = new List<BankAccount>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input
                    .Split(new string[] { " | " },
                        StringSplitOptions.RemoveEmptyEntries);
                string bank = inputParams[0];
                string name = inputParams[1];
                decimal balance = decimal.Parse(inputParams[2]);

                var newBankAccount = new BankAccount();
                newBankAccount.Bank = bank;
                newBankAccount.Name = name;
                newBankAccount.Balance = balance;

                bankNameBalance.Add(newBankAccount);

                input = Console.ReadLine();
            }
            var ordered = bankNameBalance
                .OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length);
            foreach (var order in ordered)
            {
                Console.WriteLine($"{order.Name} -> {order.Balance} ({order.Bank})");
            }
        }
    }
}
