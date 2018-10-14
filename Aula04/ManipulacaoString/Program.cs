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

            var nome = "Thiago Borges";

            //indexOf
            var indicei = nome.IndexOf("i");//mostra a posição I que é 2 pois começa da posiçao 0
            Console.WriteLine($"Indice: {indicei}"); 
            
            //substring
            var sobrenome = nome.Substring(6);//mesma coisa que a proxima linha/ pega um pedaço de string
            Console.WriteLine($"Sobrenome: {nome.Substring(6)}");

            //isNullOrEmpty verificar se tem espaços em branco ou vazia
            bool vazia = string.IsNullOrEmpty(nome.Trim());//trim corta os espaço em branco

            //isNullOrWhiteSpace faz o mesmo que o de cima com o trim
            bool vaziaEpaco = string.IsNullOrWhiteSpace(nome);

            //replace
            nome = nome.Replace("g","f");//substitui o g pelo f na variável

            //toUpper e toLower manda tudo para maiusculo ou minusculo
            nome = nome.ToUpper();

            Console.WriteLine("TO STRING - FORMATAÇÃO");

            //ToString
            decimal valor = 80;
            Console.WriteLine($"Valor : {valor.ToString("c")}"); //formata para dinheiro
            Console.WriteLine($"Valor : {valor.ToString("c", new CultureInfo("en-US"))}"); //formata para dinheiro com a cultura americana
            Console.WriteLine($"Valor : {valor.ToString("d2")}"); 
            Console.WriteLine($"Valor : {valor.ToString("n2", new CultureInfo("en-US"))}");

            Console.WriteLine($"Valor : {valor:c}"); //formata para dinheiro
            Console.WriteLine($"Valor : {valor:n2}");
            Console.WriteLine($"Valor : {valor:d2}");
            

            Console.ReadKey();

        }
    }
}
