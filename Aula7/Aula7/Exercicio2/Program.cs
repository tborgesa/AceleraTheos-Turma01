using System;

namespace Exercicio2
{
    class Program
    {
        static double _saldo = 0;


        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                string mensagem = @"Escolha umas das opções abaixo:
                                        01 - Consultar Saldo
                                        02 - Saque
                                        03 - Depósito
                                        04 - Sair do sistema";

                Console.Clear();
                Console.WriteLine(mensagem);

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Saldo();
                        break;
                    case 2:
                        Saque();
                        break;
                    case 3:
                        Deposito();
                        break;
                    case 4:
                        sair = true;
                        Console.WriteLine("Você escolheu sair do sistema.");
                        break;
                    default:
                        break;
                }

                Console.ReadKey();
            }
        }

        private static void Deposito()
        {
            Console.WriteLine("Qual o valor do depósito?");
            double deposito = double.Parse(Console.ReadLine());

            if (deposito > 0)
            {
                _saldo = _saldo + deposito;
                Console.WriteLine("Depósito efetuado com sucesso!");
            }
            else
                Console.WriteLine("O valor de depósito deve ser maior que zero!");

        }

        private static void Saque()
        {
            Console.WriteLine("Qual o valor do saque?");
            double saque = double.Parse(Console.ReadLine());

            if (_saldo >= saque)
            {
                _saldo = _saldo - saque;
                Console.WriteLine("Saque realizado com sucesso!");
            }   
            else
                Console.WriteLine("O valor de saque deve ser maior ou igual o saldo da conta!");
        }

        private static void Saldo()
        {
            Console.WriteLine($"Seu saldo é {_saldo}");
        }
    }
}
