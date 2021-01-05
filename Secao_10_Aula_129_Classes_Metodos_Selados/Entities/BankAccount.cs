using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_129_Classes_Metodos_Selados.Entities
{
    class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public double AccountBalance { get; protected set; }

        public BankAccount()
        {
        }
        public BankAccount(int number, string holder, double balance)
        {
            AccountNumber = number;
            AccountHolder = holder;
            AccountBalance = balance;
        }
        public virtual void WithdrawFunds(double amount)
        {
            AccountBalance -= (amount + 1.5);
        }
        public void DepositFunds(double amount)
        {
            AccountBalance += amount;
        }
    }
}
