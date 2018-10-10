using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Calcule o novo salario de um funcionario, sabendo que o reajuste dado para todos na empresa foi de 5%.
            double salarioAntigo;
            double salarioNovo;
            

            Console.WriteLine("Calculo de reajuste de salario\n");
            Console.WriteLine("Digite o salário atual");
            salarioAntigo = double.Parse(Console.ReadLine());

            salarioNovo = salarioAntigo + (salarioAntigo * 0.05);
            
            Console.WriteLine($"Com o reajuste de 5% o salário passará a ser {Math.Round(salarioNovo,2)}");
            Console.ReadKey();
        }
    }
}
