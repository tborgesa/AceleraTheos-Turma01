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
            string cor = "grafite";
            cor.Substring(3);//: Começará no f e será cortado até o fim. Retorno: "fite". Indice começar na posição 3 e corta até o final da string pois nao tem um parametro de parada
            cor.Substring(0, 4);//: Comecará no g(primeiro caracter = posiçao 0) e cortará até a posição 4 (caracteres).Retorno: "grafi".

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
