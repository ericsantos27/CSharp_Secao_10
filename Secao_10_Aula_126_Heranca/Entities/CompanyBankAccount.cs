using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_126_Heranca.Entities
{
    class CompanyBankAccount : PersonBankAccount
    {
        public double LoanLimit { get; set; }
        public CompanyBankAccount()
        {
        }
        public CompanyBankAccount(int number, string holder, double balance, double loan) : base(number, holder, balance)
        {
            LoanLimit = loan;
        }

        public void BankLoan(double amount)
        {
            if(amount < LoanLimit)
            {
                AccountBalance += amount;
            }
        }
    }
}
