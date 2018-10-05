using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VALOR X REFERÊNCIA");

            int valor = 54;
            ref int valor2 = ref valor;

            valor2 = 2;
            Console.WriteLine($"Valor: {valor}.");
            Console.WriteLine($"Valor2: {valor2}");

            Console.ReadLine();
        }

    }
}
