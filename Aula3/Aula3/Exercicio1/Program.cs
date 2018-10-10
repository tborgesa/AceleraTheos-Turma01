using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Calcular o volume de uma caixa retangular.
            //formula: V = l × w × h.

            Console.WriteLine("por favor, Informe o comprimento da caixa em centimetros");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("por favor, Informe a largura da caixa em centimetros");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("por favor, Informe a altura da caixa em centimetros");
            double altura = Convert.ToDouble(Console.ReadLine());


            double volume = comprimento * largura * altura;
            Console.WriteLine($"o Volume da caixa é {volume} cm3.");
            

            Console.ReadKey();
        }
    }
}
