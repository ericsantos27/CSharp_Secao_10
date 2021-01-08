using System;
using System.Collections.Generic;
using Secao_10_Aula_136_Exercicio_Metodos_Abstratos.Entidades;
using Secao_10_Aula_136_Exercicio_Metodos_Abstratos.Entidades.Enum;

namespace Secao_10_Aula_136_Exercicio_Metodos_Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();
            Console.Write("Número de figuras: ");
            int shapeNumber = int.Parse(Console.ReadLine());

            for(int i = 1; i <= shapeNumber; i++)
            {
                Console.WriteLine("Dados da figura {0}", i);
                Console.Write("Retangulo ou Círculo (R / C): ");
                string shapeType = Console.ReadLine();
                Console.Write("Cor (Preto, Azul, Vermelho): ");
                Color shapeColor = Enum.Parse<Color>(Console.ReadLine());
                if(shapeType == "R")
                {
                    Console.Write("Largura: ");
                    double shapeWidth = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double shapeHeight = double.Parse(Console.ReadLine());
                    shapeList.Add(new Rectangle(shapeColor, shapeWidth, shapeHeight));
                }
                else
                {
                    Console.Write("Raio: ");
                    double radiusShape = double.Parse(Console.ReadLine());
                    shapeList.Add(new Circle(shapeColor, radiusShape));
                }
            }

            Console.WriteLine("Área das figuras: ");
            foreach(Shape element in shapeList)
            {
                Console.WriteLine("Área: {0:F2}", element.Area());
            }
        }
    }
}
