using System;
using System.Globalization;

namespace ExemploManipulacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String: Manipulação");

            string nome = "Thiago Borges";

            //indexOf
            var indicei = nome.IndexOf("i");
            Console.WriteLine($"Índice: {indicei}");

            //substring
            var sobrenome = nome.Substring(indicei);

            //isNullOrEmpty
            bool vazia = string.IsNullOrEmpty(nome.Trim());

            //isNullOrWhiteSpace
            bool vaziaEspaco = string.IsNullOrWhiteSpace(nome);
            Console.WriteLine($"Vazia: {vaziaEspaco}");

            //replace
            nome = nome.Replace("g", "f");
            Console.WriteLine($"Nome: {nome}");

            //toUpper e toLower
            nome = nome.ToUpper();
            Console.WriteLine($"Nome: {nome}");

            Console.WriteLine($"Sobrenome: {sobrenome}");

            Console.WriteLine("TO STRING: FORMATAÇÃO");

            decimal valor = 100_000_000_000;

            int numero = 9;

            Console.WriteLine($"Valor: {valor.ToString("c")}");
            Console.WriteLine($"Valor: {valor.ToString("c", new CultureInfo("en-US"))}");
            Console.WriteLine($"Numero: {numero.ToString("d2")}");
            Console.WriteLine($"Valor: {valor.ToString("n2", new CultureInfo("en-US"))}");

            Console.WriteLine($"Valor: {valor:c}");
 
            Console.ReadKey();
        }
    }
}
