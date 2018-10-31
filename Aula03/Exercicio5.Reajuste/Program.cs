using System;

namespace Exercicio5.Reajuste
{
    class Program
    {
        //5. Calcule o novo salario de um funcionario, sabendo que o reajuste dado para todos na empresa foi de 5%.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário do funcionário:");
            double salario = Convert.ToDouble(Console.ReadLine());
            
            double salarioReajustado = salario * 1.05;
            salarioReajustado = Math.Round(salarioReajustado, 2);
            
            Console.WriteLine($"O salário do funcionário com o novo reajuste é de R$ {salarioReajustado}.");
            
            Console.ReadKey();
        }
    }
}
