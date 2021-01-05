using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_132_Exercício_Heranca_Polimorfismo.Entidades
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }
        public OutsourcedEmployee()
        {
        }
        public OutsourcedEmployee(string name, int hour, double value, double additional) : base(name, hour, value)
        {
            AdditionalCharge = additional;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
