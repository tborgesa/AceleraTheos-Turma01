using System;

namespace Exercicio03
{
    class Program
    {

        static string _mensagemInvalida = "Entrada inválida, digite somente números inteiros!";

        static void Main(string[] args)
        {
            /* 3. Solicite ao usuário 10 números e no final diga quantos números são menores que 100, 
                  quantos estão entre 100 e 200 e quantos são maiores que 200. */

            int numeroMenor100 = 0,
                numeroEntre100e200 = 0,
                numeroMaior200 = 0;

            Console.Write("DIGITE 10 NÚMEROS INTEIROS\n");

            for (int i = 1; i <= 10; i++)
            {                
                Console.Write($"\nDigite o número {i}: ");
                string numero = Console.ReadLine();

                if (!int.TryParse(numero, out int numeroValido))
                {
                    Console.WriteLine(_mensagemInvalida);                
                }

                if (numeroValido < 100)
                {
                    numeroMenor100++;
                }
                else if (numeroValido >= 100 && numeroValido <= 200)
                {
                    numeroEntre100e200++;
                }
                else if (numeroValido > 200)
                {
                    numeroMaior200++;
                }
            }

            Console.WriteLine($"\n{numeroMenor100} número(s) é(são) menore(s) que 100.");
            Console.WriteLine($"\n{numeroEntre100e200} número(s) é(estão) entre o intervalo 100 e 200.");
            Console.WriteLine($"\n{numeroMaior200} número(s) é(são) maior(es) que 200.");

            Console.ReadKey();
        }
    }
}
