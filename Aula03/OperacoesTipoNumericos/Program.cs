using System;

namespace OperacoesTipoNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OPERAÇÃO ENTRE DADOS NUMÉRICOS.");
            Console.WriteLine($"Adição: 8 + 4 = {8 + 4}");
            Console.WriteLine($"Subtração: 8 - 4 = {8 - 4}");
            Console.WriteLine($"Multiplicação: 8 * 4 = {8 * 4}");
            Console.WriteLine($"Divisão: 8 / 4 = {8 / 4}");
            Console.WriteLine($"Resto: 8 % 4 = {8 % 4}");

            Console.WriteLine();
            Console.WriteLine("INCREMENTAL.");
            var incrementarAntes = 1;
            var incrementarDepois = 1;
            Console.WriteLine($"Incrementar antes: {++incrementarAntes}");
            Console.WriteLine($"Incrementar depois: {incrementarDepois++}");
            Console.WriteLine($"Resultado Final Incrementar antes: {incrementarAntes}");
            Console.WriteLine($"Resultado Final  Incrementar depois: {incrementarDepois}");

            //https://docs.microsoft.com/pt-br/dotnet/api/system.math?redirectedfrom=MSDN&view=netframework-4.7.2
            Console.WriteLine();
            Console.WriteLine("BIBLIOTECA MATH.");
            double tipoDouble = 87.87;
            double doubleArredondado = Math.Round(tipoDouble, 0);
            Console.WriteLine($"Double: {tipoDouble}");
            Console.WriteLine($"Double arredondado: {doubleArredondado}");

            Console.ReadKey();
        }
    }
}
