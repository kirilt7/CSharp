using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.BankSystem
{
    public interface IDepositable
    {
        void MakeDeposit(decimal sum);
    }
}
