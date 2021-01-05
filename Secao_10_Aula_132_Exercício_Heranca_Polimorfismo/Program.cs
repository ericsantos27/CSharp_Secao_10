using System;
using System.Collections.Generic;
using Secao_10_Aula_132_Exercício_Heranca_Polimorfismo.Entidades;

namespace Secao_10_Aula_132_Exercício_Heranca_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número de empregados: ");
            int empNumb = int.Parse(Console.ReadLine());
            Console.WriteLine();
            List<Employee> empList = new List<Employee>();

            for (int i = 1; i <= empNumb; i++)
            {
                Console.WriteLine("Dados do empregado {0}:", i);
                Console.Write("Empregado terceirizado (S/N): ");
                string outsourced = Console.ReadLine();
                Console.Write("Nome: ");
                string wkName = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int hourQty = int.Parse(Console.ReadLine());
                Console.Write("Valor hora: ");
                double hourValue = double.Parse(Console.ReadLine());
                if (outsourced == "N")
                {
                    empList.Add(new Employee(wkName, hourQty, hourValue));
                }
                else
                {
                    Console.Write("Custo adicional: ");
                    double charge = double.Parse(Console.ReadLine());
                    empList.Add(new OutsourcedEmployee(wkName, hourQty, hourValue, charge));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pagamentos: ");
            foreach (Employee element in empList)
            {
                Console.WriteLine("{0} - $ {1:F2}", element.WorkerName, element.Payment());
            }
        }
    }
}
