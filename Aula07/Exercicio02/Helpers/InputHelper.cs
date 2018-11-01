using System;


namespace Exercicio01.Helpers
{
    public class InputHelper
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
        public static double GetInputDouble(string texto, string mensagemInvalida)
        {
            while (true)
            {
                Console.WriteLine(texto);

                string numeroDigitado = Console.ReadLine();

                if (!double.TryParse(numeroDigitado, out var numero))
                {
                    MensagemUsuario(mensagemInvalida);
                }
                else
                    return numero;
            }
        }

        public static string GetInputString(string texto, string mensagemInvalida)
        {
            while (true)
            {
                Console.WriteLine(texto);

                string informacaoDigitada = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(informacaoDigitada))
                {
                    MensagemUsuario(mensagemInvalida);
                }
                else
                    return informacaoDigitada;
            }
        }
        public static void MensagemUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}
