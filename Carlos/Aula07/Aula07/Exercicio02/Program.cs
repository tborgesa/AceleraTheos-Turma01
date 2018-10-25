using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static double _saldo = 0,
                      _deposito = 0,
                      _saque = 0;

        static void Main(string[] args)
        {
            /*
             2) Escreva um programa que apresente quatro opções: 
                - consulta saldo
                - saque
                - depósito
                - sair. 
                O saldo deve iniciar em R$ 0,00 e ele deve se atualizado com saque ou deposito.
                O saldo não pode ser negativo.             
             */

            while (true)
            {
                int opcao = MenuPrincipal();

                switch (opcao)
                {
                    case 1:
                        ConsultarSaldo();
                        break;

                    case 2:
                        Sacar();
                        break;

                    case 3:
                        Deposito();
                        break;

                    case 4:
                        Console.WriteLine("Você escolheu sair!");
                        Console.ReadKey();
                        return;

                    default:
                        break;
                }
            }
        }

        private static int MenuPrincipal()
        {
            while (true)
            {
                string menu = @"ESCOLHA UMA DAS OPÇÕES ABAIXO:
01 - Consultar saldo
02 - Saque
03 - Depósito
04 - Sair.";
                Console.Clear();
                Console.WriteLine(menu);

                if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= 4)
                    return opcao;
                else
                {
                    Console.WriteLine("Digite uma opção valida!");
                    Console.ReadKey();
                }
            }
        }

        private static void ConsultarSaldo()
        {
            Console.Clear();
            Console.WriteLine($"Saldo atual: R${_saldo:N2}.");
            Console.ReadKey();
        }

        private static void Sacar()
        {
            Console.Clear();
            Console.WriteLine($"Digite o valor do saque:");
            _saque = double.Parse(Console.ReadLine());

            if (_saque > _saldo)
            {
                Console.WriteLine("Saque maior que saldo atual, por favor digite um valor menor!");
                Console.ReadKey();
            }
            else 
                _saldo -= _saque;
        }

        private static void Deposito()
        {
            Console.Clear();
            Console.WriteLine($"Digite o valor do depósito:");
            _deposito = double.Parse(Console.ReadLine());

            _saldo += _deposito;
        }
    }
}
