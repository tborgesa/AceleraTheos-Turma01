using System;
using System.Globalization;

namespace ManipulacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://docs.microsoft.com/pt-br/dotnet/api/system.string?view=netframework-4.7.2

            Console.WriteLine("STRING: MANIPULAÇÃO");

            var nome = "Carlos Alexandre de Paula";

            //Metodo IndexOf
            var indice =  nome.IndexOf("P");
            Console.WriteLine($"Indice: {indice}");

            //Metodo Substring
            var sobrenome = nome.Substring(20);
            Console.WriteLine($"Sobrenome: {nome}");

            //Metodo isNullOrEmpty
            bool vazia = string.IsNullOrEmpty(nome.Trim());
            Console.WriteLine($"{nome}");

            //Metodo isNullOrWhiteSpace
            bool vaziaEspaco = string.IsNullOrWhiteSpace(nome);
            Console.WriteLine($"{nome}");

            //Metodo Replace
            nome = nome.Replace("C","Z");
            Console.WriteLine($"Replace: {nome}");

            //Metodo toUpper e toLower
            nome = nome.ToUpper();
            Console.WriteLine($"Nome: {nome}");

            nome = nome.ToLower();
            Console.WriteLine($"Nome: {nome}");

            //Formatacao String
            decimal valor = 100_000_000_000;
            Console.WriteLine($"Valor: {valor:c}");
            Console.WriteLine($"Valor: {valor.ToString("c")}");
            Console.WriteLine($"Valor: {valor.ToString("c", new CultureInfo("en-us"))}");
            Console.WriteLine($"Valor: {valor.ToString("n2", new CultureInfo("en-us"))}");

            double numero = 9;
            Console.WriteLine($"valor: {valor:c}");
            Console.WriteLine($"Numero: {numero:d2}");
            Console.WriteLine($"valor: {numero:n2}");



            Console.ReadKey();
        }
    }
}
