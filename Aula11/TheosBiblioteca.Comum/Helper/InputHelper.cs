using System;

namespace TheosBiblioteca.Helper
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

        public static void MensagemUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}