using System;
using System.Globalization;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Volte ao exercicio 5 da aula anterior e formate o salário apresentando sempre 2 casas decimais.

            Console.WriteLine("\nInforme o salário do funcionário:");
            decimal salarioFuncionario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o percentual para ser reajustado:");
            decimal percentualReajuste = decimal.Parse(Console.ReadLine());

            var valorReajustado = salarioFuncionario + (salarioFuncionario * (percentualReajuste / 100));

            Console.WriteLine($"\nO valor do salário com reajuste é de {valorReajustado.ToString("n2", new CultureInfo("pt-BR"))}.");

            Console.ReadKey();
        }
    }
}
