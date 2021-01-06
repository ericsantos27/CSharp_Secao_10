using System;
using Secao_10_Aula_133_Exercicio_Proposto_Heranca_Polimorfismo.Entidades;
using System.Collections.Generic;

namespace Secao_10_Aula_133_Exercicio_Proposto_Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de produtos: ");
            int prdQty = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Product> productList = new List<Product>();

            for(int i = 1; i <= prdQty; i++)
            {
                Console.WriteLine("Dados do produto {0}: ", i);
                Console.Write("Produto Comum, Usado ou Importado (C, U ou I): ");
                string prdType = Console.ReadLine();

                string prdName;
                double prdPrice;
                DateTime manufactDate;
                double prdFee;

                if(prdType == "C")
                {
                    Console.Write("Nome: ");
                    prdName = Console.ReadLine();
                    Console.Write("Preço: ");
                    prdPrice = double.Parse(Console.ReadLine());
                    productList.Add(new Product(prdName, prdPrice));
                    Console.WriteLine();
                }
                else if(prdType == "U")
                {
                    Console.Write("Nome: ");
                    prdName = Console.ReadLine();
                    Console.Write("Preço: ");
                    prdPrice = double.Parse(Console.ReadLine());
                    Console.Write("Data de fabricação: ");
                    manufactDate = DateTime.Parse(Console.ReadLine());
                    productList.Add(new UsedProduct(prdName, prdPrice, manufactDate));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Nome: ");
                    prdName = Console.ReadLine();
                    Console.Write("Preço: ");
                    prdPrice = double.Parse(Console.ReadLine());
                    Console.Write("Taxa de importação: ");
                    prdFee = double.Parse(Console.ReadLine());
                    productList.Add(new ImportedProduct(prdName, prdPrice, prdFee));
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Etiqueta de preço: ");
            foreach(Product element in productList)
            {
                Console.WriteLine(element.PriceTag());
            }
        }
    }
}
