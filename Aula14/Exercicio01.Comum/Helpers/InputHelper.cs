using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Comum.Helpers
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

        public static double GetInputDouble(string texto, string mensagemInvalido)
        {
            while (true)
            {
                //Console.Clear();
                Console.WriteLine(texto);

                string numeroDigitado = Console.ReadLine();
                if (!double.TryParse(numeroDigitado, out var numero))
                {
                    mensagemUsuario(mensagemInvalido);
                }
                else
                {
                    return numero;
                }
            }
        }

        public static string GetInputString(string texto)
        {
            Console.WriteLine(texto);
            string nome = Console.ReadLine();
            return nome;
        }

        public static void mensagemUsuario(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }

    }
}
