using Refatoracao.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        private static string _mensagemInvalida = "Entrada inválida, tente novamente.";
        static void Main(string[] args)
        {
            int numero = InputHelper.GetInputInt("Digite um número", _mensagemInvalida);
            Console.WriteLine($"{numero}! = {CalcularFatorial(numero)}");
            Console.ReadKey();
        }

        static double CalcularFatorial(int numero)
        {
            if (numero <= 1)
                return 1;
            else
                return numero * CalcularFatorial(numero - 1);
        }

    }
}
