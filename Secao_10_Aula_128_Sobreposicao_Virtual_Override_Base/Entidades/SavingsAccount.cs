using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_128_Sobreposicao_Virtual_Override_Base.Entidades
{
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }
        public SavingsAccount(int number, string holder, double balance, double interest) : base(number, holder, balance)
        {
            InterestRate = interest;
        }

        public void UpdateBalance()
        {
            AccountBalance += (AccountBalance * InterestRate);
        }
        public override void WithdrawFunds(double amount)
        {
            AccountBalance -= amount;
        }

    }
}
