using System;

namespace Refatoracao.Helpers
{
    public static class InputHelper
    {
        public static int GetInputInt(string texto, string mensagemInvalido)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine(texto);

                string numeroDigitado = Console.ReadLine();

                if (!int.TryParse(numeroDigitado, out var numero))
                {
                    Console.WriteLine(mensagemInvalido);
                    Console.ReadKey();
                }
                else
                    return numero;
            }
        }
    }
}
