using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_127_Upcasting_Downcasting.Entities
{
    class SavingsAccount : PersonBankAccount
    {
        public double InterestRate { get; set; }
        public SavingsAccount()
        {
        }
        public SavingsAccount(int account, string holder, double balance, double interest) : base(account, holder, balance)
        {
            InterestRate = interest;
        }
        public void UpdateBalance()
        {
            AccountBalance += (AccountBalance * InterestRate);
        }
    }
}
