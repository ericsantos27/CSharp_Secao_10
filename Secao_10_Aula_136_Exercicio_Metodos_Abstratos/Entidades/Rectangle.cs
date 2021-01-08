using System;
using System.Collections.Generic;
using System.Text;
using Secao_10_Aula_136_Exercicio_Metodos_Abstratos.Entidades.Enum;

namespace Secao_10_Aula_136_Exercicio_Metodos_Abstratos.Entidades
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
        }
        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
