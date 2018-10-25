using System;

namespace Exercicio03
{
    class Program
    {
        static int _fatorial = 0;
        static string _numeroDigitado = null;

        static void Main(string[] args)
        {
            /*
                3) Peça um numero para o usuario e calcule o fatorial desse numero.
            */

            while (true)
            {
                int opcao = MenuPrincipal();

                switch (opcao)
                {
                    case 1:
                        CalcularFatorial();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Você escolheu sair!");
                        Console.ReadKey();
                        return;

                    default:
                        break;
                }
            }
        }

        private static void CalcularFatorial()
        {
            Console.Clear();
            Console.WriteLine("Digite um número para calcular seu fatorial:");
            _numeroDigitado = Console.ReadLine();

            if(int.TryParse(_numeroDigitado, out int numero))
            {
                _fatorial = numero;

                for (int i = numero - 1; i > 1; i--)
                {
                    _fatorial *= i;
                }

                Console.WriteLine($"\nFatorial do número: {numero} é: {_fatorial}");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Número inválido!");
                Console.ReadKey();
        }

        private static int MenuPrincipal()
        {
            while (true)
            {
                string menu = @"ESCOLHA UMA DAS OPÇÕES ABAIXO:
01 - Calcular o fatorial de um número
02 - Sair.";
                Console.Clear();
                Console.WriteLine(menu);

                if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= 2)
                    return opcao;
                else
                {
                    Console.WriteLine("Digite uma opção valida!");
                    Console.ReadKey();
                }
            }
        }
    }
}



