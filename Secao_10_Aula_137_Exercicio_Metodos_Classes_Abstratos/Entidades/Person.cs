using System;
using System.Collections.Generic;
using System.Text;
using Secao_10_Aula_137_Exercicio_Metodos_Classes_Abstratos.Entidades.Enums;

namespace Secao_10_Aula_137_Exercicio_Metodos_Classes_Abstratos.Entidades
{
    class Person : TaxPayer
    {
        public double HealthExpenditure { get; set; }

        public Person()
        {
        }
        public Person(string name, double income, PersonType type, double health) : base(name, income, type)
        {
            HealthExpenditure = health;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000.00)
            {
                return (AnnualIncome * 0.15) - (HealthExpenditure * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenditure * 0.5);
            }
        }
    }
}
