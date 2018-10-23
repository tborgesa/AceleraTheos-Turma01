using System;

namespace ControleFluxo
{
    class Program
    {
        static string _mensagemInvalida = "Entrada inválida, execute o sistema e tente novamente!";

        static void Main(string[] args)
        {
            Console.WriteLine($"CONTROLE DE FLUXO");

            //ExemploIf();
            //ExemploIfElse();
            //ExemploIfElseIfElse();
            //ExemploFor();
            //ExemploWhile();
            ExemploSwitch();

            Console.ReadKey();

        }

        private static void ExemploIf()
        {
            Console.WriteLine($"Digite seu nome");

            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
                Console.WriteLine(_mensagemInvalida);
        }

        private static void ExemploIfElse()
        {
            Console.WriteLine($"Digite seu nome");

            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
                Console.WriteLine(_mensagemInvalida); 
            else
                Console.WriteLine($"Olá {nome}");
        }

        private static void ExemploIfElseIfElse()
        {
            Console.WriteLine($"Digite seu nome:");
            string nome = Console.ReadLine();
            DateTime agora = DateTime.Now;

            if(string.IsNullOrWhiteSpace(nome))
                Console.WriteLine(_mensagemInvalida);
            else if(agora.Hour > 6 && agora.Hour < 12)
                Console.WriteLine($"Bom dia, {nome}");
            else if (agora.Hour > 12 && agora.Hour < 18)
                Console.WriteLine($"Boa tarde, {nome}");
            else
                Console.WriteLine($"Boa noite, {nome}");
        }

        private static void ExemploFor()
        {
            Console.WriteLine($"Digite um número entre 10 e 20");

            string numeroDigitado = Console.ReadLine();

            //int numero; pode tbm ser declarado no TryPase
            if (!int.TryParse(numeroDigitado, out var numero))
            {
                Console.WriteLine(_mensagemInvalida);

                return;
            }
            else if (numero < 10 || numero > 20)
            {
                Console.WriteLine(_mensagemInvalida);

                return;
            }

            Console.WriteLine($"Imprimindo os números pares:");

            //Até quando a condição for verdadeira
            for (int i = numero; i >= 0; i--)
            {
                //continue: para a atual interação do for
                //break: para a execução toda do for e continua a execução do sistema

                if (i == numero / 2)
                    continue;

                if (i % 2 == 0)
                    Console.WriteLine($"{i}");
            }
        }

        private static void ExemploWhile()
        {
            Console.WriteLine($"Digite um número entre 10 e 20");

            string numeroDigitado = Console.ReadLine();

            //int numero; pode tbm ser declarado no TryPase
            if (!int.TryParse(numeroDigitado, out var numero))
            {
                Console.WriteLine(_mensagemInvalida);

                return;
            }

            Console.WriteLine($"Imprimindo os números pares:");

            int numeroInicial = numero;

            //Se a condição for verdadeira
            while (numeroInicial >= 0)
            {
               if (numeroInicial % 2 == 0)
                    Console.WriteLine($"{numeroInicial}");

                numeroInicial--;
            }
        }

        private static void ExemploSwitch()
        {
            bool saiu = false;
            while (!saiu)
            {
                string menu = @"
                 Escolha uma opção abaixo:
                 01 - Imprime a data atual
                 02 - Soma de dois numeros
                 03 - Sair";

                Console.WriteLine($"{menu}");
                string numeroDigitado = Console.ReadLine();

                //int numero; pode tbm ser declarado no TryPase
                if (!int.TryParse(numeroDigitado, out var numero))
                {
                    Console.WriteLine(_mensagemInvalida);

                    return;
                }

                switch (numero)
                {
                    case 1:
                        Console.WriteLine($"{DateTime.Now:dd/MM/yyyy}");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine($"1 + 1: {1 + 1}");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Você saiu!");
                        saiu = true;
                        break;

                    default:
                        Console.WriteLine(_mensagemInvalida);
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
