using System;

namespace ConversaoTipoNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/implicit-numeric-conversions-table
            //https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/explicit-numeric-conversions-table
            Console.WriteLine();
            Console.WriteLine("CONVERSÃO DE DADOS NUMÉRICOS.");

            //http://www.profcardy.com/cardicas/binario.php?decimal=256
            Console.WriteLine();
            Console.WriteLine("Tipos Integrais.");
            short tiposhort = 256; //0100000000
            byte byteConvertido = (byte)tiposhort;
            Console.WriteLine($"Short: {tiposhort}");
            Console.WriteLine($"Short para byte: {byteConvertido}");


            Console.WriteLine();
            Console.WriteLine("Tipos Flutuantes.");
            double tipoDouble = 40.87;
            int intConvertido = (int)tipoDouble;


            Console.WriteLine($"Double: {tipoDouble}");
            Console.WriteLine($"Double convertido para int: {intConvertido}");

            Console.ReadKey();
        }
    }
}
