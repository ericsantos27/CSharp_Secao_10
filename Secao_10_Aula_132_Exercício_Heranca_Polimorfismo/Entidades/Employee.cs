using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_132_Exercício_Heranca_Polimorfismo.Entidades
{
    class Employee
    {
        public string WorkerName { get; set; }
        public int HoursQty { get; set; }
        public double HourValue { get; set; }

        public Employee()
        {
        }
        public Employee(string name, int hour, double value)
        {
            WorkerName = name;
            HoursQty = hour;
            HourValue = value;
        }

        public virtual double Payment()
        {
            return HoursQty * HourValue;
        }
    }
}
