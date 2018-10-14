using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Volte ao exercicio 5 da aula anterior e formate o salário apresentando sempre 2 casas decimais.
            decimal salarioAntigo;
            decimal salarioNovo;
            decimal porcentagem = 0.05m;

            Console.WriteLine("Calculo de reajuste de salario\n");
            Console.WriteLine("Digite o salário atual");
            salarioAntigo = decimal.Parse(Console.ReadLine());

            salarioNovo = salarioAntigo + (salarioAntigo * porcentagem);

            Console.WriteLine($"Com o reajuste de 5% o salário passará a ser {salarioNovo.ToString("c")}");
            Console.ReadKey();
        }
    }
}
