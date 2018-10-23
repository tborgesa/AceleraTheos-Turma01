using System;

namespace ControleFluxo
{
    class Program
    {
        static string _mensagemInvalida = "Entrada inválida, execute novamente o sistema, para tentar de novo.";


        static void Main(string[] args)
        {
            Console.WriteLine("Controle de Fluxo");

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
            Console.WriteLine("Digite seu nome.");

            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
                Console.WriteLine(_mensagemInvalida);
                      
        }

        private static void ExemploIfElse()
        {
            Console.WriteLine("Digite seu nome.");

            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
                Console.WriteLine(_mensagemInvalida);
            else
                Console.WriteLine("Bem Vindo(a).");

        }

        private static void ExemploIfElseIfElse()
        {
            Console.WriteLine("Digite seu nome.");

            string nome = Console.ReadLine();
            DateTime agora = DateTime.Now;

            if (string.IsNullOrWhiteSpace(nome))
                Console.WriteLine(_mensagemInvalida);
            else if (agora.Hour > 6 && agora.Hour < 12)
                Console.WriteLine("Bom dia. Bem Vindo(a).");
            else if (agora.Hour > 12 && agora.Hour < 18)
                Console.WriteLine("Boa tarde. Bem Vindo(a).");
            else
                Console.WriteLine("Boa noite. Bem Vindo(a).");

        }

        private static void ExemploFor()
        {
            Console.WriteLine("Digite um numero de 10 a 20.");

            string numeroDigitado = Console.ReadLine();


            //int.TryParse(numeroDigitado, out numero); //out é variavel de saida
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


            Console.WriteLine("Imprimindo os números pares.");


            for (int i = numero; i >= 0; i--) //i+=2
            {
                //continue
                if (i == numero / 2)
                    break;

                if (i % 2 == 0)
                    Console.WriteLine($"{i}");
            }

        }

        private static void ExemploWhile()
            {
                string numeroDigitado = Console.ReadLine();

                if (!int.TryParse(numeroDigitado, out var numero))
                    {
                        Console.WriteLine(_mensagemInvalida);
                        return;
                    }

                var numeroInicial = numero;
                while (numero >= 0)
                    {
                        //if (numeroInicial == numero / 2)
                        //continue;

                        if (numeroInicial % 2 == 0)
                            Console.WriteLine($"{numeroInicial}");

                        numeroInicial--;

                //o for é melhor quando é incremental
                //o while é melhor para validações em que enquanto o usuario não digitar a informação certa, continuar no while
                    }




            }

        private static void ExemploSwitch()
        {
            {
                string mensagem = @"Escolha umas das opções abaixo:
                                        01 - Mostrar a hora atual
                                        02 - Somar dois números aleatorios
                                        03 - Sair do sistema";

                Console.WriteLine(mensagem);

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine(_mensagemInvalida);
                    return;
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"{DateTime.Now:dd/MM/yyyy}");
                        break;
                    case 2:
                        int numero1 = new Random().Next(100, 150);
                        int numero2 = new Random().Next(151, 200);
                        Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu sair do sistema.");
                        break;
                    default:
                        Console.WriteLine(_mensagemInvalida);
                        break;
                }
            }
        }
    }
}

