using System;

namespace BibliotecaTheos.Comum.Helpers.InputHelper
{
    public class InputHelper
    {
        public static int GetInputInt(string texto, string mensagemInvalida, bool limparTela = true)
        {
            while (true)
            {
                if (limparTela)
                    Console.Clear();

                Console.WriteLine(texto);
                string numeroDigitado = Console.ReadLine();

                if (!int.TryParse(numeroDigitado, out var numero))
                    MensagemUsuario(mensagemInvalida);
                else
                    return numero;
            }
        }

        private static void MensagemUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}
