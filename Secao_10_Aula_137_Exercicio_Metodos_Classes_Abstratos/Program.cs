using System;
using System.Collections.Generic;
using Secao_10_Aula_137_Exercicio_Metodos_Classes_Abstratos.Entidades;
using Secao_10_Aula_137_Exercicio_Metodos_Classes_Abstratos.Entidades.Enums;

namespace Secao_10_Aula_137_Exercicio_Metodos_Classes_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayerList = new List<TaxPayer>();
            Console.Write("Número de contribuintes: ");
            int taxPayerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for(int i = 1; i <= taxPayerNumber; i++)
            {
                Console.WriteLine("Dados do contribuinte {0}", i);
                Console.Write("Pessoa ou Organização: ");
                PersonType taxPayerType = Enum.Parse<PersonType>(Console.ReadLine());
                Console.Write("Nome ou Razão Social: ");
                string taxPayerName = Console.ReadLine();
                Console.Write("Receita anual: ");
                double taxPayerIncome = double.Parse(Console.ReadLine());
                if(taxPayerType == PersonType.P)
                {
                    Console.Write("Valor de despesas com saúde: ");
                    double healthExpenditure = double.Parse(Console.ReadLine());
                    taxPayerList.Add(new Person(taxPayerName, taxPayerIncome, taxPayerType, healthExpenditure));
                }
                else if(taxPayerType == PersonType.O)
                {
                    Console.Write("Número de funcinários: ");
                    int employeeNumber = int.Parse(Console.ReadLine());
                    taxPayerList.Add(new Organization(taxPayerName, taxPayerIncome, taxPayerType, employeeNumber));
                }
                else
                {
                    Console.WriteLine("Digite um valor válido (P / O)");
                }
            }
            Console.WriteLine("Pagamento de impostos: ");
            foreach(TaxPayer element in taxPayerList)
            {
                Console.WriteLine("Nome do contribuinte: {0}; Valor pago: $ {1:F2} ", element.Name, element.Tax());
            }
        }
    }
}
