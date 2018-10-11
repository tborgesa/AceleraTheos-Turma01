using System;

/*
 * 1. Calcular o volume de uma caixa retangular.
 */

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de base");
            double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de altura");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de profundidade");
            double p = Double.Parse(Console.ReadLine());

            double volume = b * a * p;

            Console.Clear();
            Console.WriteLine($"As medidas de {b} m de base, {a} m de altura, {p} m de profundidade o valor do volume é : {volume} cubico(s)");
            Console.ReadKey();
        }
    }
}
