using System;


namespace Exercicio03
{
    class Program
    {
        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";
        static void Main(string[] args)
        {
            /*3. Solicite ao usuário 10 números e no final diga quantos números são menores que 100, quantos estão entre 100 e 200 e quantos são maiores que 200.*/

            VerificaNumero();
            Console.ReadKey();
        }

        private static void VerificaNumero()
        {
            string numeroDigitado;
            int intervaloMenor = 0;
            int intervaloMediano = 0;
            int intervaloMaior = 0;


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Digite um número");
                numeroDigitado = Console.ReadLine();

                if (!int.TryParse(numeroDigitado, out var numero))
                {
                    Console.WriteLine(_mensagemInvalido);
                    return;
                }

                if (numero < 100)
                    intervaloMenor += 1;
                else if (numero > 100 && numero < 201)
                    intervaloMediano += 1;
                else if (numero > 200)
                    intervaloMaior += 1;
            }

            Console.WriteLine($"Foram digitados {intervaloMenor} menores que 100, {intervaloMediano} entre 100 e 200 e {intervaloMaior} maiores que 200.");

            Console.ReadKey();

        }

    }
}

