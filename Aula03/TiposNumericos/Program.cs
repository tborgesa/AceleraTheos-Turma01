using System;

namespace TiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TIPOS DE DADOS NUMÉRICOS.");
            Console.WriteLine();

            Console.WriteLine($"bool");
            Console.WriteLine($"Padrão: {default(bool)} / Tamanho: 1 bit");

            Console.WriteLine($"");
            Console.WriteLine($"byte");
            Console.WriteLine($"Padrão: {default(bool)} / Menor: {byte.MinValue} / Maior: {byte.MaxValue}  / Tamanho: 8 bits.");

            Console.WriteLine($"");
            Console.WriteLine($"short");
            Console.WriteLine($"Padrão: {default(short)} / Menor: {short.MinValue} / Maior: {short.MaxValue}  / Tamanho: 16 bits.");

            Console.WriteLine($"");
            Console.WriteLine($"int");
            Console.WriteLine($"Padrão: {default(int)} / Menor: {int.MinValue} / Maior: {int.MaxValue} / Tamanho: 32 bits.");

            Console.WriteLine($"");
            Console.WriteLine($"long");
            Console.WriteLine($"Padrão: {default(long)} / Menor: {long.MinValue} / Maior: {long.MaxValue} / Tamanho: 64 bits.");

            Console.WriteLine($"");
            Console.WriteLine($"float");
            Console.WriteLine($"Padrão: {default(float)} / Menor: {float.MinValue} / Maior: {float.MaxValue} / Precisão: 7 casas decimais.");

            Console.WriteLine($"");
            Console.WriteLine($"double");
            Console.WriteLine($"Padrão: {default(double)} / Menor: {double.MinValue} / Maior: {double.MaxValue} / Precisão: 15 casas decimais.");

            Console.WriteLine($"");
            Console.WriteLine($"decimal");
            Console.WriteLine($"Padrão: {default(decimal)} / Menor: {decimal.MinValue} / Maior: {decimal.MaxValue}  / Precisão: 28 casas decimais.");

            Console.ReadKey();
        }
    }
}
