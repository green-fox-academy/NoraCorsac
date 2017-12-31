using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class UsaDollar : Currency
    {
        public UsaDollar(int value) : base("USD", "Federal Reserve System", value)
        {

        }
    }
}
