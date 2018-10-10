using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Converter a temperatura em graus Fahrenheit para graus Celsius.
            double fahrenheit;
            double celsius;

            Console.WriteLine("Converter Fahrenheit para Celsius\n");
            Console.WriteLine("Digite a quantidade de graus Fahrenheit");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit-32) / 1.8;

            Console.WriteLine($"O resultado é {Math.Round(celsius,1)}º Celsius");
            Console.ReadKey();

        }
    }
}
