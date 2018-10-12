using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Volte ao exercicio 5 da aula anterior e formate o salário apresentando sempre 2 casas decimais.

            Console.WriteLine("por favor, Informe seu salario.");
            double salario = Convert.ToDouble(Console.ReadLine());


            double novoSalario = (salario * 0.05) + salario;


            Console.WriteLine($"Com o reajuste de 5%, seu salario passa a ser de R$ {novoSalario:n2}.");


            Console.ReadKey();
        }
    }
}
