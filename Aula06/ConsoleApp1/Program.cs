using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";

        static void Main(string[] args)
        {
            Console.WriteLine("CONTROLE DE FLUXO");

            ExemploIf();
            ExemploIfElse();
            ExemploIfElseIf();
            ExemploFor();
            ExemploWhile();
            ExemploSwitch();

            Console.ReadKey();

        }

        private static void ExemploSwitch()
        {
            bool saiu = false;
            while (!saiu)
            {
                string menu = @"
Escolha uma opção abaixo:
01 - Imprime a data atual
02 - Soma dois numeros
03 - sair
";
                Console.WriteLine(menu);
                string numeroDigitado = Console.ReadLine();
                if (!int.TryParse(numeroDigitado, out var numero))
                {
                    Console.WriteLine(_mensagemInvalido);
                    return;
                }

                switch (numero)
                {
                    case 1:
                        Console.WriteLine($"{DateTime.Now:dd/MM/yyyy}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine($"1 + 1 = {1 + 1}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Você saiu!");
                        break;
                    default:
                        Console.WriteLine(_mensagemInvalido);
                        Console.ReadKey();
                        break;
                }


            }


        }


        private static void ExemploWhile()
        {

            Console.WriteLine("Digite um numero entre 10 e 20 ");

            string numeroDigitado = Console.ReadLine();

            if (!int.TryParse(numeroDigitado, out var numero))
            {
                Console.WriteLine(_mensagemInvalido);
                return;
            }
            else if (numero < 10 || numero > 20)
            {
                Console.WriteLine(_mensagemInvalido);
                return;
            }

            int numeroInicial = numero;

            while (numeroInicial > 0)
            {

                if (numeroInicial % 2 == 0)
                {
                    Console.WriteLine($"{numeroInicial}");
                }

                numeroInicial--;
            }

        }

        private static void ExemploFor()
        {
            Console.WriteLine("Digite um numero entre 10 e 20 ");

            string numeroDigitado = Console.ReadLine();
            
            if (!int.TryParse(numeroDigitado, out var numero))
            {
                Console.WriteLine(_mensagemInvalido);
                return;
            }
            else if (numero <10 || numero > 20)
            {
                Console.WriteLine(_mensagemInvalido);
                return;
            }

            for (int i = numero; i >=0 ; i--)
            {
                //continue: para a atual iteração/execuçao do for
                //break: para a execução toda do for e continua a execução do sistema

                if (i == numero / 2 )
                {
                    continue;
                }


                if (i % 2 ==0)
                {
                    Console.WriteLine($"{i}");
                }
            }


        }


        private static void ExemploIf()
        {
            Console.WriteLine("Digite seu nome: ");

            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine(_mensagemInvalido);
            }

        }

        private static void ExemploIfElse()
        {
            Console.WriteLine("Digite seu nome: ");

            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine(_mensagemInvalido);
            }

            else
            {
                Console.WriteLine($"Olá {nome}");
            }
        }

        private static void ExemploIfElseIf()
        {
            Console.WriteLine("Digite seu nome: ");

            string nome = Console.ReadLine();
            DateTime agora = DateTime.Now;

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine(_mensagemInvalido);
            }

            else if (agora.Hour >6 && agora.Hour<12)
            {
                Console.WriteLine($"Bom dia {nome}");
            }

            else if (agora.Hour > 12 && agora.Hour < 18)
            {
                Console.WriteLine($"Boa tarde {nome}");
            }

            else
            {
                Console.WriteLine($"Boa Noite {nome}");
            }
        }
    }
}
