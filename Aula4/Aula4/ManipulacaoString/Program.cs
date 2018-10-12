using System;
using System.Globalization;

namespace ManipulacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String: Manipulação");

            string nome = "Aline Estércio";


            //indexOf
            var indicei = nome.IndexOf("i");

            Console.WriteLine($"Indice :{indicei,1}");


            //Substring
            var sobreNome = nome.Substring(indicei);

            Console.WriteLine($"Sobrenome :{sobreNome}");
            Console.WriteLine($"Sobrenome :{indicei,1}");


            //isNullOrEmpty
            bool vazia = string.IsNullOrEmpty(nome.Trim()); //para verificar se o usuario digitou vazio a informação


            //replace
            nome = nome.Replace("A", "E");

            Console.WriteLine($"Sobrenome :{nome}");


            //toUpper e toLower
            nome = nome.ToUpper();

            Console.WriteLine($"Nome Maiusculo :{nome}");


            //Formatação para moedas
            Console.WriteLine("to string - formatação");

            decimal valor = 80;
            Console.WriteLine($"Valor: {valor.ToString("c")}");
            Console.WriteLine($"Valor: {valor:c}");

            Console.WriteLine($"Valor: {valor.ToString("c", new CultureInfo("es-US"))}");



            int numero = 9;
            Console.WriteLine($"Numero: {numero.ToString("D2")}");//duas casas, sem ser decimal 09
            Console.WriteLine($"Numero: {numero.ToString("n2")}");//duas casas decimais 9,00

            Console.WriteLine($"Numero: {numero:D2}");
            Console.WriteLine($"Numero: {numero:n2}");

            Console.ReadKey();
        }
    }
}
