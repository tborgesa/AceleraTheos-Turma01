using System;
using Refatoracao.Helpers;

namespace Refatoracao
{
    class Program
    {
        private static string _mensagemInvalido = "Entrada inválida, tente novamente.";

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
01 - Imprime a data atual
02 - Soma dois numeros
03 - Sair
";
                int numero = InputHelper.GetInputInt(menu, _mensagemInvalido);

                switch (numero)
                {
                    case 1:
                        ImprimeData();
                        break;
                    case 2:
                        SomaNumeros();
                        break;
                    case 3:
                        InputHelper.MensagemUsuario("Voce saiu!");
                        return;
                    default:
                        InputHelper.MensagemUsuario(_mensagemInvalido);
                        break;
                }
            }
        }

        private static void ImprimeData()
        {
            InputHelper.MensagemUsuario($"{DateTime.Now:dd/MM/yyyy}"); ;
        }

        private static void SomaNumeros()
        {
            int numero = InputHelper.GetInputInt("Digite um número:", _mensagemInvalido);
            int numero2 = InputHelper.GetInputInt("Digite mais um número:", _mensagemInvalido);

            InputHelper.MensagemUsuario($"{numero} + {numero2} = {numero + numero2}");
        }
        
    }
}
