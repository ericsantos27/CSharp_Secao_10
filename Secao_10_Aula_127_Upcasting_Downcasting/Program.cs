using System;
using Secao_10_Aula_127_Upcasting_Downcasting.Entities;

namespace Secao_10_Aula_127_Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONTA PESSOA FÍSICA:");
            Console.Write("Titular da conta: ");
            string holderPersonAccount = Console.ReadLine();
            Console.Write("Número da conta: ");
            int numberPersonAccount = int.Parse(Console.ReadLine());
            Console.Write("Saldo da conta: ");
            double balancePersonAccount = double.Parse(Console.ReadLine());
            PersonBankAccount personBank = new PersonBankAccount(numberPersonAccount, holderPersonAccount, balancePersonAccount);

            Console.WriteLine("CONTA PESSOA JURÍDICA:");
            Console.Write("Titular da conta: ");
            string holderCompAccount = Console.ReadLine();
            Console.Write("Número da conta: ");
            int numberCompAccount = int.Parse(Console.ReadLine());
            Console.Write("Saldo da conta: ");
            double balanceCompAccount = double.Parse(Console.ReadLine());
            Console.Write("Valor do empréstimo: ");
            double loanBank = double.Parse(Console.ReadLine());
            CompanyBankAccount companyBank = new CompanyBankAccount(numberCompAccount, holderCompAccount, balanceCompAccount, loanBank);

            // Upcasting - criar uma variável do tipo de uma subclasse e atribuir a ela um objeto de uma outra subclasse, desde que as duas subclasses
            // pertençam a mesma superclasse

            PersonBankAccount compSavingAccount = companyBank;
            PersonBankAccount personBank1 = new SavingsAccount(numberPersonAccount, holderPersonAccount, balancePersonAccount, 0.01);
            PersonBankAccount personBank2 = new CompanyBankAccount(numberPersonAccount, holderPersonAccount, balancePersonAccount, 500.00);

            // Downcasting - converter uma variável do tipo de uma superclasse para uma do tipo de uma subclasse

            CompanyBankAccount companyBank1 = (CompanyBankAccount)personBank2;

        }
    }
}
