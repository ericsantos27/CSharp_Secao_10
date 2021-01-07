using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_134_Classes_Abstratas.Entidades
{
    abstract class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double AccountBalance { get; set; }
        
        public BankAccount()
        {
        }
        public BankAccount(int number, string holder, double balance)
        {
            AccountNumber = number;
            AccountHolder = holder;
            AccountBalance = balance;
        }

        public void BankDeposit(double amount)
        {
            AccountBalance += amount;
        }
        public virtual void BankWithdraw(double amount)
        {
            AccountBalance -= amount;
        }
    }
}
