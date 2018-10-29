using System;

/*
 3) Peça um numero para o usuario e calcule o fatorial desse numero.
 */

namespace Exercico03
{
    class Program
    {
        static int total = 1;
        static int numero;

        static void Main(string[] args)
        {
            telaMenu();
        }

        private static void telaMenu()
        {
            Console.WriteLine("Digite um valor inteiro para ver o valor do fatorial:");

            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Valor errado");
                Console.ReadKey();
                Console.Clear();
            }


            fatorial(numero);
            Console.WriteLine($"Valor de {numero}: {total}");

            Console.ReadKey();
        }

        private static void fatorial(int numero)
        {
            for (int n = 1; n <= numero; n++)
            {
                total *= n;
            }
        }
    }
}
