using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_127_Upcasting_Downcasting
{
    class CompanyBankAccount : PersonBankAccount
    {
        public double LoanLimit { get; set; }
        public CompanyBankAccount()
        {
        }
        public CompanyBankAccount(int account, string holder, double balance, double loan) : base(account, holder, balance)
        {
            LoanLimit = loan;
        }

        public void BankLoan(double amount)
        {
            if(amount <= LoanLimit)
            {
                AccountBalance += amount;
            }
        }
    }
}
