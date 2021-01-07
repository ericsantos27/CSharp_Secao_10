using System;
using Secao_10_Aula_134_Classes_Abstratas.Entidades;
using System.Collections.Generic;

namespace Secao_10_Aula_134_Classes_Abstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount companyAccount = new BusinessAccount(78994, "Cire Sistemas LTda", 15568.12, 60000.00);
            SavingsAccount personSavingAccount = new SavingsAccount(55678, "Eric Santos", 6978.00, 1.1);

            // Abaixo, código comentado com a classe BankAccount que é uma classe abstrata e, portanto, não pode ser instanciada
            /* BankAccount accountBank = new BankAccount(22335, "Companu Bank", 5000.00); */

            /* 
             * Tendo uma lista baseada em um tipo genérico (BankAccount) é possível instanciar esta lista com vários tipos diferentes herdados
             * deste tipo genérico, percorrer esta lista e utilizar os dados, independente do tipo instanciado
             */ 

            List<BankAccount> bankList = new List<BankAccount>();

            bankList.Add(new BusinessAccount(88774, "Transportadora Rodonel", 11569.23, 20000.00));
            bankList.Add(new BusinessAccount(69971, "Companhia Elétrica Denso", 545698.45, 1000000.00));
            bankList.Add(new SavingsAccount(22451, "Mario de Andrade", 5465.32, 0.55));
            bankList.Add(new SavingsAccount(34428, "Lazaro Ramos", 28972.89, 0.61));

            foreach(BankAccount element in bankList)
            {
                Console.WriteLine("Saldo da conta {0}: $ {1:F2}", element.AccountNumber, element.AccountBalance);
            }

            double sum = 0.0;
            foreach(BankAccount element in bankList)
            {
                sum += element.AccountBalance;
            }
            Console.WriteLine("Soma do saldo das contas: {0:F2}", sum);

            foreach(BankAccount element in bankList)
            {
                element.BankWithdraw(100.00);
            }

            foreach(BankAccount element in bankList)
            {
                Console.WriteLine("Saldo da conta {0}: $ {1:F2}", element.AccountNumber, element.AccountBalance);
            }

            double sum2 = 0.0;
            foreach(BankAccount element in bankList)
            {
                sum2 += element.AccountBalance;
            }
            Console.WriteLine("Soma do sado das contas: {0:F2}", sum2);
        }
    }
}
