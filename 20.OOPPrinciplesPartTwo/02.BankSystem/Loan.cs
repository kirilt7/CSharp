using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankSystem
{
    public class Loan : Account
    {
    public Loan(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate){}
    public override decimal CalcAmount(int mounth)
    {
        if (this.Customer is Individual)
        {
            mounth = Math.Max(0, (mounth - 3));
        }
        if (this.Customer is Company)
        {
            mounth = Math.Max(0, (mounth - 2));
        }
        return base.CalcAmount(mounth);
    }
    }
}
