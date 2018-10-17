using System;

namespace ProvaInicial.Trapezio
{
    class Program
    {
        /*
        Questão 4 (2 pontos)

        De acordo com o código abaixo, o que o sistema irá imprimir na tela do Console?

        static void Main(string[] args)
        {
            int n = 4;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j >= n) break;
                    Console.Write(i + 1);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
 
        1
        22
        333
        4444
        */

        static void Main(string[] args)
        {
            int n = 4;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j >= n) break;
                    Console.Write(i + 1);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
