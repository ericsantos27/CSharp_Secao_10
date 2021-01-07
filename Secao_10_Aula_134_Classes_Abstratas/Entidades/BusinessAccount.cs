using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_134_Classes_Abstratas.Entidades
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

        public override void BankWithdraw(double amount)
        {
            base.BankWithdraw(amount + 2.00);
        }

        public void BankLoan(double amount)
        {
            if(amount <= LoanLimit)
            {
                AccountBalance += amount;
            }
            else
            {
                Console.WriteLine("Operação cancelada. Valor solicitado acima do limite disponibilizado");
            }
        }
    }
}
