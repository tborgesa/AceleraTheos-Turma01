using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String: Manipulação");
            string nome = "Thiago Borges";
            Console.ReadKey();

            //indexOf fornece o indice do caracter 
            var indice = nome.IndexOf("i");
            Console.WriteLine($"INdice: {indice}");
            Console.ReadKey();

            //SubString
            var sobrenome = nome.Substring(6);
            Console.WriteLine($"Sobre nome teste{sobrenome}");

            //IsNullOrEmpty
            bool vazia = string.IsNullOrEmpty(nome.Trim());

            //IsNullOrWriteSpcae
            bool vaziaEspaco = string.IsNullOrWhiteSpace(nome);
            Console.WriteLine($"Vaiza: { vaziaEspaco}");
            Console.ReadKey();

            //replace
            nome = nome.Replace("g","f");

            //ToUpper
            nome = nome.ToUpper();
            Console.WriteLine(nome);
            Console.ReadKey();

            //ToLower
            nome = nome.ToLower();
            Console.WriteLine(nome);
            Console.ReadKey();

            Console.WriteLine("TO STRING - FORMATAÇÂO");

            decimal valor = 80;

            //UnderLine na variável é ignorado
            decimal valors = 100_100_100;

            decimal numero = 92;


            Console.WriteLine($"Numero:{numero.ToString("d2")}");

            Console.WriteLine($"Valor :{valor.ToString("c")}");
            Console.WriteLine($"Valor :{valor.ToString("n2", new CultureInfo("en-US"))}");
            Console.WriteLine($"Valor  teste:{valor:c)}");
            //Console.WriteLine($"Valor :{valor.ToString("c", new CultureInfo("en-US"))}");

            //Converter valor para moeda os dois abaixos são equivalente
            Console.WriteLine($"Valor :{valor.ToString("c")}");
            Console.WriteLine($"Valor :{valor:c)}");




            //String.Join uma lista de string juntar caracter no meio
            //string.Join


            Console.WriteLine($"Sobrenome: {sobrenome}");

            Console.ReadKey();
        }
    }
}
