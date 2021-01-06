using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_133_Exercicio_Proposto_Heranca_Polimorfismo.Entidades
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            ManufactureDate = date;
        }

        public override string PriceTag()
        {
            return "Produto: " + ProductName + "(usado); Preço: $ " + ProductPrice.ToString("F2") + "; Data de fabricação: " + ManufactureDate.ToString("dd/MM/yyyy");
        }
    }
}
