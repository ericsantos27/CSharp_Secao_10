using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_127_Upcasting_Downcasting
{
    class PersonBankAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public double AccountBalance { get; protected set; }

        public PersonBankAccount()
        {
        }
        public PersonBankAccount(int account, string holder, double balance)
        {
            AccountNumber = account;
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
