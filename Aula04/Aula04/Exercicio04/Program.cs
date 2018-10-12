using System;
/*
 *   Calcule o novo salario de um funcionario, sabendo que o reajuste dado para todos na empresa foi de 5%.
     4. Volte ao exercicio 5 da aula anterior e formate o salário apresentando sempre 2 casas decimais.
     */

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do salario");
            float sal = float.Parse(Console.ReadLine());

            sal = sal * (float)1.05;
            var aux = Math.Round(sal, 2);

            Console.WriteLine($"O salario atuial é R${aux:f2}");
            Console.ReadKey();
        }
    }
}
