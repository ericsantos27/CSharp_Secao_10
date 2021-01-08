using System;
using System.Collections.Generic;
using System.Text;
using Secao_10_Aula_136_Exercicio_Metodos_Abstratos.Entidades.Enum;

namespace Secao_10_Aula_136_Exercicio_Metodos_Abstratos.Entidades
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {
        }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
