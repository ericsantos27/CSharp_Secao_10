using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_129_Classes_Metodos_Selados.Entities
{
    // Comando "sealed" = comando para 'selar' uma classe, impedindo q ela seja herdada por outra. 
    sealed class BusinessAccount : BankAccount
    {
        public double LoanLimit { get; private set; }
        public BusinessAccount()
        {
        }
        public BusinessAccount(int number, string holder, double balance, double loan) : base(number, holder, balance)
        {
            LoanLimit = loan;
        }
        public void BankLoan(double amount)
        {
            if(amount <= LoanLimit)
            {
                AccountBalance += amount;
            }
            else
            {
                Console.WriteLine("Sem limite para esta transação")
            }
        }
    }
}
