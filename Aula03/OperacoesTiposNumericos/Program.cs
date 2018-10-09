using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 10 + 5;
            int subtracao = 10 - 5;
            int multiplacao = 10 * 5;
            int divisao = 10 / 5;
            int resto = 10 % 5;

            int incrementalAntes = 1;
            int incrementalDepois = 1;

            Console.WriteLine($"Antes : {++incrementalAntes}");//incrementa no valor antes e retorna o valor incrementado
            Console.WriteLine($"Depois : {incrementalDepois++}");//incrementar o valor depois de mandar o retorno, ou seja retorna o valor 1 

            Console.WriteLine($"Antes : {incrementalAntes}");//valor incrementado 2
            Console.WriteLine($"Depois : {incrementalDepois}");//valor incrementado 2

            Console.ReadKey();



            /*---------------------------------------------------------------*/
            //Biblioteca MATH
            double bibliotecaMath = Math.Round(56.87);
            Console.WriteLine($"Arredondamento: {bibliotecaMath}");

            Console.ReadKey();

        }
    }
}
