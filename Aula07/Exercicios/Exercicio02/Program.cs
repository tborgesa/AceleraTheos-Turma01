using System;
using Exercicio02.Helpers;
/*2) Escreva um programa que apresente quatro opções: 
- consulta saldo
- saque
- depósito
- sair.
O saldo deve iniciar em R$ 0,00 e ele deve se atualizado com saque ou deposito.
O saldo não pode ser negativo.*/

namespace Exercicio02
{
    class Program
    {
        static string _mensagemInvalida = "Entrada inválida. Tente novamente!";
        static double _saldo;

        static void Main(string[] args)
        {
            MenuPrincipal();
        }

        private static void MenuPrincipal()
        {
            while (true)
            {
                Console.Clear();

                string menu = @"ESCOLHA UMA OPÇÃO:
01 - Consultar saldo;
02 - Sacar;
03 - Depositar;
04 - Sair;
";
                int opcao = InputHelper.GetInputInt(menu, _mensagemInvalida);
                Console.Clear();
                {
                    switch (opcao)
                    {
                        case 1:
                            ConsultarSaldo();
                            break;
                        case 2:
                            double valorSaque = InputHelper.GetInputDouble("Informe o valor do saque: ", _mensagemInvalida);
                            Sacar(valorSaque);
                            break;
                        case 3:
                            double valorDeposito = InputHelper.GetInputDouble("Informe o valor do depósito: ", _mensagemInvalida);
                            Depositar(valorDeposito);
                            break;
                        case 4:
                            Console.WriteLine("Você escolheu sair!");
                            Console.ReadKey();
                            return;
                        default:
                            Console.WriteLine(_mensagemInvalida);
                            break;
                    }
                    Console.ReadKey();
                }
            }
        }

        private static void Depositar(double valorDeposito)
        {
            _saldo += valorDeposito;
            Console.WriteLine($"Depósito de {valorDeposito:c} realizado com sucesso! Seu saldo atual é de {_saldo:c}");
        }

        static void Sacar(double valor)
        {
            if(_saldo <= 0 || _saldo < valor)
                Console.WriteLine("Você não possui saldo suficiente para realizar este saque.");
            else
            {
                _saldo -= valor;
                Console.WriteLine($"Saque de {valor:c} realizado com sucesso! Seu saldo atual é {_saldo:c}");
            }

            
        }

        static void ConsultarSaldo()
        {
            Console.WriteLine($"Seu saldo é de {_saldo:c}");
        }
    }
}
