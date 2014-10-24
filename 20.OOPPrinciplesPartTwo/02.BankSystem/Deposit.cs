using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankSystem
{
    public class Deposit : Account, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate) { }
        public void Withdraw(decimal sum)
        {
            this.Balance -= sum;
        }
        public override decimal CalcAmount(int month)
        {
            if (this.Balance>0 && this.Balance<1000)
            {
                return 0;
            }
            else
            {
                return base.CalcAmount(month);
            }
        }
    }
}
