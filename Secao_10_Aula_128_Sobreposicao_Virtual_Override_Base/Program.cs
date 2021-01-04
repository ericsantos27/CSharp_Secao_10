using System;
using Secao_10_Aula_128_Sobreposicao_Virtual_Override_Base;
using Secao_10_Aula_128_Sobreposicao_Virtual_Override_Base.Entidades;

namespace Secao_10_Aula_128_Sobreposicao_Virtual_Override_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTA POUPANÇA:");
            Console.Write("Titular da conta: ");
            string holderPersonAccount = Console.ReadLine();
            Console.Write("Número da conta: ");
            int numberPersonAccount = int.Parse(Console.ReadLine());
            Console.Write("Saldo da conta: ");
            double balancePersonAccount = double.Parse(Console.ReadLine());
            double interestBank = 0.01;
            Console.WriteLine("Taxa de juros poupança: {0}%", interestBank * 100);
            BankAccount savingPersonBank = new SavingsAccount(numberPersonAccount, holderPersonAccount, balancePersonAccount, interestBank);
            Console.WriteLine();

            Console.WriteLine("CONTA PESSOA JURÍDICA:");
            Console.Write("Titular da conta: ");
            string holderCompAccount = Console.ReadLine();
            Console.Write("Número da conta: ");
            int numberCompAccount = int.Parse(Console.ReadLine());
            Console.Write("Saldo da conta: ");
            double balanceCompAccount = double.Parse(Console.ReadLine());
            // Console.Write("Valor do empréstimo: ");
            // double loanBank = double.Parse(Console.ReadLine());
            BankAccount companyBank = new BusinessAccount(numberCompAccount, holderCompAccount, balanceCompAccount, 100.00);
            Console.WriteLine();

            Console.Write("Valor para saque poupança: ");
            double withdrawAmount = double.Parse(Console.ReadLine());
            savingPersonBank.WithdrawFunds(withdrawAmount);
            Console.WriteLine("Saldo da conta poupança: {0:F2}", savingPersonBank.AccountBalance);
            Console.WriteLine();

            Console.Write("Valor para saque conta corporativa: ");
            double withdrawCorpAmount = double.Parse(Console.ReadLine());
            companyBank.WithdrawFunds(withdrawCorpAmount);
            Console.WriteLine("Saldo da conta corporativa: {0:F2}", companyBank.AccountBalance);

        }
    }
}
