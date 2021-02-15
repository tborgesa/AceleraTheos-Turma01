using System;

namespace Refatoracao.Helpers
{
    public static class InputHelper
    {
        //bool limparTela = true - é um parâmetro opcional, pode ter ou não.
        public static int GetInputInt(string texto, string mensagemInvalido, bool limparTela = true)
        {
            while (true)
            {
                if(limparTela)
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
