using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiQueijos.Comum.Helpers
{
    public class InputHelper
    {
        public static int GetInputInt(string texto, string mensagemInvalido)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(texto);

                string numeroDigitado = Console.ReadLine();
                if (!int.TryParse(numeroDigitado,out var numero))
                {
                    mensagemUsuario(mensagemInvalido);
                }
                else
                {
                    return numero;
                }
            }
        }

        public static void mensagemUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }

    }
}
