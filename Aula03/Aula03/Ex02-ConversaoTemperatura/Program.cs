using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_ConversaoTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converter Fahrenheit para graus Celsius\n");
            double fahrenheit;
            double celsius;

            Console.WriteLine("Digite a temperatura em Fahrenheit");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Temperatura em graus celsius Cº: {celsius:n2}");

            Console.ReadLine();
        }
    }
}
