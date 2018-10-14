using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Volte ao exercicio 2 da aula anterior e formate a temperatura apresentando sempre 2 casas decimais.
            
            float fahrenheit;
            float celsius;

            Console.WriteLine("Converter Fahrenheit para Celsius\n");
            Console.WriteLine("Digite a quantidade de graus Fahrenheit");
            fahrenheit = float.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) / 1.8f;

            Console.WriteLine($"O resultado é {celsius.ToString("N2")}º Celsius");
            Console.ReadKey();
        }
    }
}
