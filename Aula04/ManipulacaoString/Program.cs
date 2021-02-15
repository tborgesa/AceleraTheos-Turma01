using System;
using System.Globalization;

namespace ManipulacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STRING: MANIPULAÇÃO");

            string nome = "Talita Monteiro";
            string nomevazio = "    ";

            //indexOf
            var indicei = nome.IndexOf("i");
            Console.WriteLine($"Indíce: {indicei}");


            //Substring
            var sobrenome = nome.Substring(7);
            Console.WriteLine($"Sobrenome: {sobrenome}");

            //isNullOfEmpty
            bool vazia = string.IsNullOrEmpty(nome.Trim()); //Trim() ignora os espaços.
            Console.WriteLine($"IsNullOrEmpty: {vazia}");

            //isNullOfWhiteSpace
            bool semnada = string.IsNullOrWhiteSpace(nomevazio);
            Console.WriteLine($"IsNullOrWhiteSpate: {semnada}");

            //Replace
            nome = nome.Replace("i", "u");
            Console.WriteLine($"Substitui a por i: {nome}");

            nome = nome.Replace("u", "i");

            //toUpper and toLower
            nome = nome.ToUpper();
            Console.WriteLine($"ToUpper: {nome}");

            nome = nome.ToLower();
            Console.WriteLine($"toLower: {nome}");

            //toString
            Console.WriteLine("TO STRING - FORMATAÇÃO");

            decimal valor = 800_000_000_000;
            int numero = 9;

            Console.WriteLine($"Valor sem toString: {valor}");

            Console.WriteLine($"Valor: {valor.ToString("c")}");
            Console.WriteLine($"Valor: {valor.ToString("c", new CultureInfo("en-US"))}"); //new CultureInfo transforma em dólar.
            Console.WriteLine($"Numero: {numero.ToString("d2")}");
            Console.WriteLine($"Numero: {numero.ToString("n2", new CultureInfo("es-US"))}");

            Console.WriteLine($"Valor: {valor: c}");
            Console.WriteLine($"Número: {numero: d2}");
            Console.WriteLine($"Valor: {valor:n2}");

            Console.ReadKey();
        }
    }
}
