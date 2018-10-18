using System;


namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor x Referencia");

            int valor = 5;
            int valor2 = valor;
            valor2 = 4;

            Console.WriteLine($"Valor: {valor}");
            Console.WriteLine($"Valor2: {valor2}");
            Console.ReadKey();
        }
    }
}
