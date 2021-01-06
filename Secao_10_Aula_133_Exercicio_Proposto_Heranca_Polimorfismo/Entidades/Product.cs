using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_133_Exercicio_Proposto_Heranca_Polimorfismo.Entidades
{
    class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            ProductName = name;
            ProductPrice = price;
        }

        public virtual string PriceTag()
        {
            return "Produto: " + ProductName + "; Preço: $ " + ProductPrice.ToString("F2");
        }
    }
}
