using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_128_Sobreposicao_Virtual_Override_Base.Entidades
{
    class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public double AccountBalance { get; protected set; }

        public BankAccount()
        {
        }
        public BankAccount (int number, string holder, double balance)
        {
            AccountNumber = number;
            AccountHolder = holder;
            AccountBalance = balance;
        }

        public virtual void WithdrawFunds(double amount)
        {
            AccountBalance -= (amount + 0.10);
        }
        public void DepositFunds(double amount)
        {
            AccountBalance += amount;
        }
    }
}
