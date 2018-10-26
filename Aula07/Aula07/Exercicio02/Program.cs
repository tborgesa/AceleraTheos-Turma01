﻿using Exercicio01.Helpers;
using System;

namespace Exercicio02
{
    class Program
    {
        static double _saldo = 0.0;
        static double _valor;
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
                        Sacar(_valor);
                        break;
                    case 03:
                        Depositar(_valor);
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

        private static void Depositar(double valor)
        {
            Console.Clear();
            valor = InputHelper.GetInputDouble("Digite um valor para depósito", _mensagemInvalida);
            _saldo += valor;

            InputHelper.MensagemUsuario($"Saldo atual: {_saldo:N2}");
        }

        private static void Sacar(double valor)
        {
            Console.Clear();
            valor = InputHelper.GetInputDouble("Digite um valor para saque", _mensagemInvalida);

            if (_saldo >= valor)
            {
                _saldo -= valor;
                InputHelper.MensagemUsuario($@"Saque efetuado com sucesso!
Valor sacado: {valor:N2}
saldo atual: {_saldo:N2}!");
            }
            else
            {
                InputHelper.MensagemUsuario($@"Saldo insuficiente para saque.
Valor solicitado: {valor:N2}
saldo atual: {_saldo:N2}"); 
            }     
        }

        private static void ConsultaSaldo()
        {
            Console.Clear();
            InputHelper.MensagemUsuario($"Saldo atual: {_saldo:N2}");
        }
    }
}