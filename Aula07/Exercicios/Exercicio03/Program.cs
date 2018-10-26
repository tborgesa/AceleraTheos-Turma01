using System;
using Exercicio03.Helpers;
//3) Peça um numero para o usuario e calcule o fatorial desse numero.

namespace Exercicio03
{
    class Program
    {
        static string _mensagemInvalida = "Você inseriu uma entrada inválida, tente novamente.";
        static void Main(string[] args)
        {
            int resultado = 1;
            int fatorial = InputHelper.GetInputInt("Digite um número para calcularmos o fatorial:", _mensagemInvalida);

            Console.Write($"{fatorial}! =");

            for (int i = fatorial; i >= 1; i--)
            {
                if (i == 1)
                {
                    Console.Write($"{i} ");
                    resultado = resultado * i;
                }
                else
                {
                    Console.Write($"{i}*");
                    resultado = resultado * i;
                }
            }
            Console.WriteLine($"= {resultado}");
            Console.ReadKey();
        }
    }
}
