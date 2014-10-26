using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankSystem
{
    public class Account : IDepositable
    {
        public Customer Customer { get; private set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }
        public virtual decimal CalcAmount(int month)
        {
            return month * this.InterestRate;
        }
        public void MakeDeposit(decimal sum)
        {
            this.Balance += sum;
        }
    }
}
