using System;
using System.Collections.Generic;
using System.Text;
using Secao_10_Aula_136_Exercicio_Metodos_Abstratos.Entidades.Enum;

namespace Secao_10_Aula_136_Exercicio_Metodos_Abstratos.Entidades
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }
        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
