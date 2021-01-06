using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_133_Exercicio_Proposto_Heranca_Polimorfismo.Entidades
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double fee) : base(name, price)
        {
            CustomsFee = fee;
        }

        public double TotalPrice()
        {
            return ProductPrice + CustomsFee;
        }
        public override string PriceTag()
        {
            return "Produto: " + ProductName + "; Preço: $ " + TotalPrice().ToString("F2") + "; Taxa de importação: " + CustomsFee.ToString("F2");
        }
    }
}
