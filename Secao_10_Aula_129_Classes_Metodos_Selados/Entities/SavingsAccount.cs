using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_129_Classes_Metodos_Selados.Entities
{
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; private set; }
        public SavingsAccount()
        {
        }
        public SavingsAccount(int number, string holder, double balance, double interest) : base(number, holder, balance)
        {
            InterestRate = interest;
        }
        public void UpdateBalance()
        {
            AccountBalance += InterestRate;
        }

        // Comando "sealed" - comando para 'selar' um método, impedindo q ele seja sobreposto em outra classe. Só funciona em um método já sobreposto 
        public override void WithdrawFunds(double amount)
        {
            AccountBalance -= amount;
        }
    }
}
