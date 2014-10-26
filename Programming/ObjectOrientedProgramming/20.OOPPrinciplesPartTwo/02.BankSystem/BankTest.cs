using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    class BankTest
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[] { new Deposit(new Individual("Ivanov"), 999m, 7.5m), new Mortgage(new Individual("Petrov"), 5000m, 8.3m),
            new Mortgage(new Company("Telerik"), 200000m,6.5m), new Loan(new Individual("Georgiev"), 200000m,6.5m)};
            foreach (var account in accounts)
            {
                Console.WriteLine(account.CalcAmount(10));
            }
            Console.WriteLine();
            accounts[0].MakeDeposit(500);
            Console.WriteLine(accounts[0].CalcAmount(10));
        }
    }
}
