using System;


namespace Exercicio1.Volume
{
    class Program
    {
        //1. Calcular o volume de uma caixa retangular.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o comprimento da caixa (cm):");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa (cm):");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa (cm):");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = comprimento * largura * altura;
            Console.WriteLine($"O volume da caixa é de {volume/1000} litros.");

            Console.ReadKey();
        }
    }
}
