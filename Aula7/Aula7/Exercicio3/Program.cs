using System;

namespace Exercicio3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número.");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = numero;

            for (int i = numero -1; i > 1; i--)
            {
                fatorial *=  i;
                 
            }

            Console.WriteLine($"Seu fatorial é {fatorial}");
            Console.ReadKey();
        }
    }
}
