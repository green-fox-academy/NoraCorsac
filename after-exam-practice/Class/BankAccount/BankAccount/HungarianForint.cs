using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class HungarianForint : Currency
    {
        public HungarianForint(int value) : base ("HUF", "Hungarian National Bank", value)
        {

        }
    }
}
