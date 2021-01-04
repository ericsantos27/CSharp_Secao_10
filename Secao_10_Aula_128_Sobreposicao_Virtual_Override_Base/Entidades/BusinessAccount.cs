using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_128_Sobreposicao_Virtual_Override_Base.Entidades
{
    class BusinessAccount : BankAccount
    {
        public double LoanLimit { get; set; }
        public BusinessAccount()
        {
        }
        public BusinessAccount(int number, string holder, double balance, double loan) : base(number, holder, balance)
        {
            LoanLimit = loan;
        }

        public void BankLoan(double amount)
        {
            if (amount <= LoanLimit)
            {
                AccountBalance += amount;
            }
            else
            {
                Console.WriteLine("Sem limite disponível para o valor solicitado");
            }
        }

        public override void WithdrawFunds(double amount)
        {
            base.WithdrawFunds(amount);
            AccountBalance -= 2.00;
        }
    }
}
