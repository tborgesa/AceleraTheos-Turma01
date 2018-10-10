using System;

namespace OperacaoTipoNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operações");

            int resto = 8 % 4;//mod

            int incrementarAntes = 1;
            int incrementarDepois = 1;

            Console.WriteLine($"Antes: {++incrementarAntes}");
            Console.WriteLine($"Depois: {incrementarDepois++}");

            Console.WriteLine($"Final Antes: {incrementarAntes}");
            Console.WriteLine($"Final Depois: {incrementarDepois}");

            //Biblioteca Math

            //https://docs.microsoft.com/pt-br/dotnet/api/system.math?redirectedfrom=MSDN&view=netframework-4.7.2

            double bibliotecaMath = Math.Round(55.88,1); //arredondar 1- numero de casas decimais
            Console.WriteLine($"Arredondamento: {bibliotecaMath}.");

            Console.ReadKey();

        }
    }
}
