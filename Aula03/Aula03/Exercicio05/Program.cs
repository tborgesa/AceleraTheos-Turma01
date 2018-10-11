using System;

/*
 * 5. Calcule o novo salario de um funcionario, sabendo que o reajuste dado para todos na empresa foi de 5%.
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

            Console.WriteLine($"O salario atuial é R${Math.Round(sal,2)}");
            Console.ReadKey();
        }
    }
}
