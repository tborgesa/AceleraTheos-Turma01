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
            decimal salarioAntigo;
            decimal salarioNovo;
            decimal porcentagem = 0.05m;

            Console.WriteLine("Calculo de reajuste de salario\n");
            Console.WriteLine("Digite o salário atual");
            salarioAntigo = decimal.Parse(Console.ReadLine());

            salarioNovo = salarioAntigo + (salarioAntigo * porcentagem);
            
            Console.WriteLine($"Com o reajuste de 5% o salário passará a ser {Math.Round(salarioNovo,2)}");
            Console.ReadKey();
        }
    }
}
