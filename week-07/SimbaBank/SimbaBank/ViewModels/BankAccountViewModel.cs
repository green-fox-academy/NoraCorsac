using SimbaBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimbaBank.ViewModels
{
    public class BankAccountViewModel
    {
        public List<BankAccount> AnimalList { get; set; }

        public BankAccountViewModel()
        {
            AnimalList = new List<BankAccount>();
            AddToList();
        }

        public void AddToList()
        {
            var simbax = new BankAccount
            {
                Name = "Simba",
                Balance = 2000,
                AnimalType = "Lion",
                IsKing = true,
                IsGood = true
            };
            AnimalList.Add(simbax);


            var pumba = new BankAccount
            {
                Name = "Pumba",
                Balance = 400,
                AnimalType = "Warthog",
                IsKing = false,
                IsGood = true
            };
            AnimalList.Add(pumba);

            var mufasa = new BankAccount
            {
                Name = "Mufasa",
                Balance = 500,
                AnimalType = "Lion",
                IsKing = true,
                IsGood = true
            };
            AnimalList.Add(mufasa);

            var timon = new BankAccount
            {
                Name = "Timon",
                Balance = 300,
                AnimalType = "Meerkat",
                IsKing = false,
                IsGood = true
            };
            AnimalList.Add(timon);

            var nala = new BankAccount
            {
                Name = "Nala",
                Balance = 1000,
                AnimalType = "Lion",
                IsKing = false,
                IsGood = false
            };
            AnimalList.Add(nala);
        }
        public void AddMoney()
        {
            foreach (var a in AnimalList)
            {
                if (a.IsKing)
                {
                    a.Balance += 100;
                }
                else
                {
                    a.Balance += 10;
                }
            }
        }

        public void AddAccount(string name, double balance, string type, bool isKing, bool isGood)
        {
            var account = new BankAccount
            {
                Name = name,
                Balance = balance,
                AnimalType = type,
                IsKing = isKing,
                IsGood = isGood
            };
            AnimalList.Add(account);
        }
    }
}
