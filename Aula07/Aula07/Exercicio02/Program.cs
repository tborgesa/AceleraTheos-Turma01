using Exercicio01.Helpers;
using System;

namespace Exercicio02
{
    class Program
    {
        static double _saldo = 0.0;
        private static string _mensagemInvalida = "Entrada inválida, tente novamente.";
        static void Main(string[] args)
        {
            MenuPrincipal();
           }

        private static void MenuPrincipal()
        {
            while (true)
            {
                string menu = @"
Escolha uma opção abaixo:
01 - Consultar saldo
02 - Saque
03 - Depósito
04 - Sair
";
                int opcao = InputHelper.GetInputInt(menu, _mensagemInvalida);
                switch (opcao)
                {
                    case 01:
                        ConsultaSaldo();
                        break;
                    case 02:
                        Sacar();
                        break;
                    case 03:
                        Depositar();
                        break;
                    case 04:
                        InputHelper.MensagemUsuario("Saindo do sistema!");
                        return;
                    default:
                        InputHelper.MensagemUsuario(_mensagemInvalida);
                        break;
                }
            }

        }

        private static void Depositar()
        {
            Console.Clear();
            InputHelper.MensagemUsuario("Você está no menu depositar!");
      
        }

        private static void Sacar()
        {
            Console.Clear();
            InputHelper.MensagemUsuario("Você está no menu sacar!");
       
        }

        private static void ConsultaSaldo()
        {
            Console.Clear();
            InputHelper.MensagemUsuario("Você está no menu consultar saldo!");
         
        }
    }
}
