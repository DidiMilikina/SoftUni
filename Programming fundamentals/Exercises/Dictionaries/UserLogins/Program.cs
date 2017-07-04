using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            var userLogins = new Dictionary<string, string>();
            string[] input = Console.ReadLine()
                .Split(" -> ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

            var counter = 0;
            while (input[0] != "login")
            {
                string username = input[0];
                string passoword = input[1];
                userLogins[username] = passoword;
                input = Console.ReadLine()
                    .Split(" -> ".ToCharArray(),
                        StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine()
                .Split(" -> ".ToCharArray(),
                    StringSplitOptions.RemoveEmptyEntries);

            int failed = 0;
            while (input[0] != "end")
            {
                string username = input[0];
                string password = input[1];
                if (!userLogins.ContainsKey(username) || userLogins[username] != password)
                {
                    Console.WriteLine($"{username}: login failed");
                    failed++;
                }
                else
                {
                    Console.WriteLine($"{username}: logged in successfully");
                }

                input = Console.ReadLine()
                        .Split(" -> ".ToCharArray(),
                            StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"unsuccessful login attempts: {failed}");
        }
    }
}