using System;

namespace Exercicio01.Helpers
{
    class InputHelper
    {
        public static int GetInputInt(string mensagemInvalida, bool limparTela = true)
        {

            while (true)
            {
                if (limparTela)
                    Console.Clear();

                if (!int.TryParse(Console.ReadLine(), out int numero))
                    MensagemUsuario(mensagemInvalida);
                else
                    return numero;
            }
        }

        public static double GetInputDouble(string mensagemInvalida, bool limparTela = true)
        {
            while (true)
            {
                if (limparTela)
                    Console.Clear();

                if (!double.TryParse(Console.ReadLine(), out double numero))
                    MensagemUsuario(mensagemInvalida);
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
