using System;

/*
 3) Peça um numero para o usuario e calcule o fatorial desse numero.
 */

namespace Exercico03
{
    class Program
    {
        static int fatorial = 1;
        static int resultado = 1;

        static void Main(string[] args)
        {
            if (fatorial == 0 | fatorial == 1 )
            {
                Console.WriteLine("Resultado 1");
            }

            for (int i = fatorial; i >= 1 ; i--)
            {
                resultado = resultado * fatorial;
            }

            Console.WriteLine($"Resultado {resultado}");

            Console.ReadKey();
        }
    }
}
