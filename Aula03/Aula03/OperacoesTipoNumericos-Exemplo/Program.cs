using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesTipoNumericos_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Operações");

            int soma = 10 + 4;
            int subtracao = 10 - 4;
            int multiplicacao = 10 * 4;
            int divisao = 10 / 5;
            int resto = 8 % 2;

            int incrementalAntes = 1;
            int incrementalDepois = 1;

            Console.WriteLine($"Antes: {++incrementalAntes}");
            Console.WriteLine($"Depois: {incrementalDepois++}");

            Console.WriteLine($"Final Antes: {incrementalAntes}");
            Console.WriteLine($"Final Depois: {incrementalDepois}");


            /***************/
            //Biblioteca Math, diversas operações matemáticas

            //Leva em consideração as regras matemáticas para arredondamento de valores
            double bibliotecaMath = Math.Round(56.87, 1);
            Console.WriteLine($"Arredondamento: {bibliotecaMath}");
            Console.ReadKey();
        }
    }
}
