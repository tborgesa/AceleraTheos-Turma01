using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2) Escreva um programa que apresente quatro opções: 
- consulta saldo
- saque
- depósito
- sair. 
O saldo deve iniciar em R$ 0,00 e ele deve se atualizado com saque ou deposito.
O saldo não pode ser negativo.
*/
namespace Exercicio02
{
    class Program
    {
        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";
        static decimal saldo = 0;

        static void Main(string[] args)
        {

            menuTela();
        }



        private static void menuTela()
        {


            while (true)
            {
                Tela();

                string numeroDigitado = Console.ReadLine();
                if (!int.TryParse(numeroDigitado, out var entrada))
                {
                    Console.WriteLine(_mensagemInvalido);
                }

                switch (entrada)
                {
                    case 1:
                        consultaSaldo();
                        break;
                    case 2:
                        saque();
                        break;
                    case 3:
                        deposito();
                        break;
                    case 4:
                        Console.WriteLine("Encerrado!");
                        return;
                    default:
                        Console.WriteLine(_mensagemInvalido);
                        Console.ReadKey();
                        break;
                }
            }

        }

        private static void Tela()
        {
            Console.Clear();

            Console.WriteLine(@"
            1 - consulta saldo
            2 - saque
            3 - depósito
            4 - sair"
            );
        }



        private static void deposito()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor a ser depositado:");
            saldo += decimal.Parse(Console.ReadLine());
        }

        private static void saque()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor a ser sacado:");
            var saque = decimal.Parse(Console.ReadLine());
            if(saldo > saque)
            {
                saldo -= saque;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }

            Console.ReadKey();
        }
        private static void consultaSaldo()
        {
            Console.Clear();
            Console.WriteLine("O saldo atual é:");
            Console.WriteLine(String.Format("{0:C}",saldo));
            Console.ReadKey();
        }
    }
}
