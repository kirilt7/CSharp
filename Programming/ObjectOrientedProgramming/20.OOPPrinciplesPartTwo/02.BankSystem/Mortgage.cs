using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankSystem
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate) { }
        public override decimal CalcAmount(int month)
        {
            if (this.Customer is Company)
            {
                if (month>12)
                {
                    return (month * (this.InterestRate / 2)) + base.CalcAmount(month - 12);
                }
                else
                {
                    return month * (this.InterestRate / 2);
                }
            }
            else
            {
                if (month>6)
                {
                    return base.CalcAmount(month - 6);
                }
                else
                {
                    return 0;
                }
            }
         
        }
    }
}
