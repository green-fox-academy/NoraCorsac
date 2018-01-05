using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Currency
    {
        // Create a Currency class.
        // It should have a code, a central bank name and a value field.
        // Create a constructor for setting those values.

        private string Code;
        private string BankName;
        public int Value { get; set; }

        public Currency (string code, string bankName, int value)
        {
            Code = code;
            BankName = bankName;
            Value = value;
        }
    }
}
