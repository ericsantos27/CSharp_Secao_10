using System;
using System.Collections.Generic;
using System.Text;
using Secao_10_Aula_137_Exercicio_Metodos_Classes_Abstratos.Entidades.Enums;

namespace Secao_10_Aula_137_Exercicio_Metodos_Classes_Abstratos.Entidades
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }
        public PersonType Type { get; set; }
        
        public TaxPayer()
        {
        }
        public TaxPayer(string name, double income, PersonType type)
        {
            Name = name;
            AnnualIncome = income;
            Type = type;
        }

        public abstract double Tax();
    }
}
