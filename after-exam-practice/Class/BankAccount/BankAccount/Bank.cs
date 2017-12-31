using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class Bank
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        
        public void CreateAccount(BankAccount account)
        {
            bankAccounts.Add(account);
        }

        public int GetAllMoney()
        {
            int allMoney = 0;
            foreach (var anyAccount in bankAccounts)
            {
                allMoney += anyAccount.Currency.Value;
            }
            return allMoney;
        }
    }
}
