using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_126_Heranca.Entities
{
    class PersonBankAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public double AccountBalance { get; protected set; }

        public PersonBankAccount()
        {
        }

        public PersonBankAccount(int number, string holder, double balance)
        {
            AccountNumber = number;
            AccountHolder = holder;
            AccountBalance = balance;
        }

        public void WithdrawAccount(double amount) 
        {
            AccountBalance -= amount;
        }

        public void DepositAccount(double amount)
        {
            AccountBalance += amount;
        }


    }
}
