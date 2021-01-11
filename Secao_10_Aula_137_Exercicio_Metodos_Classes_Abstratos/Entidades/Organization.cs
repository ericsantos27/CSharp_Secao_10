using System;
using System.Collections.Generic;
using System.Text;
using Secao_10_Aula_137_Exercicio_Metodos_Classes_Abstratos.Entidades.Enums;

namespace Secao_10_Aula_137_Exercicio_Metodos_Classes_Abstratos.Entidades
{
    class Organization : TaxPayer
    {
        public int EmployeeNumber { get; set; }

        public Organization()
        {
        }
        public Organization(string name, double income, PersonType type, int employee) : base(name, income, type)
        {
            EmployeeNumber = employee;
        }

        public override double Tax()
        {
            if(EmployeeNumber <= 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
