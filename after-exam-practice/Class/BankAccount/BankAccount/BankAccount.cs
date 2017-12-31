using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private string name;
        private string pinCode;
        public Currency Currency { get; set; }

        public BankAccount(string ownerName, string storedPinCode, Currency ownerCurrency)
        {
            name = ownerName;
            pinCode = storedPinCode;
            Currency = ownerCurrency;
        }
        public void Deposit(int incomingMoney)
        {
            if (incomingMoney > 0)
            {
                Currency.Value += incomingMoney;
            }
        }
        
        public int Withdraw(string storedPinCode, int amount)
        {
            int givenMoney = 0;

            try
            {
                if (storedPinCode == pinCode && Currency.Value >= amount)
                {
                    givenMoney = amount;
                    Currency.Value -= amount;
                }
                return givenMoney;
            }
            catch
            {
                if (storedPinCode != pinCode)
                {
                    Console.WriteLine("Your Pin is invalid!");
                }

                if (Currency.Value < amount)
                {
                    Console.WriteLine("You don't have enough money on your account");
                }
            }
            return 0;
        }
    }
}
