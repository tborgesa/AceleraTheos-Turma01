using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.Helpers
{
    class Input
    {
        public static int GetInputInt(string texto, string mensagemInvalido)
        {
            while (true)
            {
                Console.Clear();
                Console.Write(texto);

                string numeroDigitado = Console.ReadLine();
                if (!int.TryParse(numeroDigitado, out var numero))
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
