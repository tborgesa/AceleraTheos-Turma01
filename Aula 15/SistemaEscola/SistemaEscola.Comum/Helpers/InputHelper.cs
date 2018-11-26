using System;

namespace SistemaEscola.Comum.Helpers
{
    public static class InputHelper
    {
        public static int GetInputInt(string texto, string mensagemInvalido, bool limparTela = true)
        {
            while (true)
            {
                if (limparTela)
                    Console.Clear();

                Console.WriteLine(texto);

                string numeroDigitado = Console.ReadLine();
                if (!int.TryParse(numeroDigitado, out var numero))
                {
                    MensagemUsuario(mensagemInvalido);
                }
                else
                    return numero;
            }
        }

        public static decimal GetInputDecimal(string texto, string mensagemInvalido, bool limparTela = true)
        {
            while (true)
            {
                if (limparTela)
                    Console.Clear();

                Console.WriteLine(texto);

                string numeroDigitado = Console.ReadLine();
                if (!decimal.TryParse(numeroDigitado, out decimal numero))
                {
                    MensagemUsuario(mensagemInvalido);
                }
                else
                    return numero;
            }
        }

        public static string GetInputString(string mensagem, string mensagemInvalido, bool limparTela = true)
        {
            while (true)
            {
                if (limparTela)
                    Console.Clear();

                Console.WriteLine(mensagem);

                string textoDigitado = Console.ReadLine();
                return textoDigitado;
            }
        }

        public static void MensagemUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}
