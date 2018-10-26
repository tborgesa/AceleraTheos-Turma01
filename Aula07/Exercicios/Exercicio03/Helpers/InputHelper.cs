using System;

namespace Exercicio03.Helpers
{
    static class InputHelper
    {
        public static int GetInputInt(string texto, string mensagemInvalida)
        {
            while (true)
            {
                Console.WriteLine(texto);
                string numeroDigitado = Console.ReadLine();

                if (!int.TryParse(numeroDigitado, out var numero))
                {
                    Console.WriteLine(mensagemInvalida);
                    Console.ReadKey();
                }
                else
                    return numero;
            }
        }
    }
}
