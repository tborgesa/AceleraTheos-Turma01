using System;

namespace Exemplo02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Valor x Referência");

            int valor = 5;
            int valor2 = Alterar(ref valor);
            valor2 = 4;

            Console.WriteLine($"Valor: {valor}.");
            Console.WriteLine($"Valor2: {valor2}.");

            Console.ReadKey();

        }

        static int Alterar(ref int valor)
        {
            return valor = 2;
        }
    }
}
