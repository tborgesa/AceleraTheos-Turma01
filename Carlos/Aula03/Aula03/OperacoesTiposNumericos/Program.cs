using System;

namespace OperacoesTiposNumericos
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
            int resto = 8 % 4;

            int incrementalAntes = 1;
            int incrementalDepois = 1;

            Console.WriteLine($"Antes: {++incrementalAntes}");
            Console.WriteLine($"Depois: {incrementalDepois++}");

            Console.WriteLine($"Final Antes: {incrementalAntes}");
            Console.WriteLine($"Final Depois: {incrementalDepois}");

            /***********************/
            //Biblioteca Math
            //https://docs.microsoft.com/pt-br/dotnet/api/system.math?redirectedfrom=MSDN&view=netframework-4.7.2
            double bibliotecaMath = Math.Round(56.87,1);

            Console.WriteLine($"Arredondamento: {bibliotecaMath}");


            Console.ReadKey();
        }
    }
}

