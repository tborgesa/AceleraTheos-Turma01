using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Helpers
{
    public class InputHelper
    {
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
