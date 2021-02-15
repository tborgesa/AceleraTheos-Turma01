using System;

namespace Exercicio01.Helpers
{
    static class InputHelper
    {
        public static double GetInputDouble(string texto, string mensagemInvalida)
        {
            while (true)
            {
                Console.WriteLine(texto);
                string numeroDigitado = Console.ReadLine();

                if (!double.TryParse(numeroDigitado, out var numero))
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
