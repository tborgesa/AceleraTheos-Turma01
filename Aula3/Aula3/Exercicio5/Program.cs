using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Calcule o novo salario de um funcionario, sabendo que o reajuste dado para todos na empresa foi de 5%.
            

            Console.WriteLine("por favor, Informe seu salario.");
            double salario = Convert.ToDouble(Console.ReadLine());


            double novoSalario = (salario * 0.05) + salario;
            novoSalario = Math.Round(novoSalario, 2);


            Console.WriteLine($"Com o reajuste de 5%, seu salario passa a ser de R$ {novoSalario}.");


            Console.ReadKey();
        }
    }
}
