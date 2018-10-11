using System;

/*
*   2. Converter a temperatura em graus Fahrenheit para graus Celsius.
*/

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit");
            float fahrenheit = float.Parse(Console.ReadLine());

            float celcius = (fahrenheit - 32) * (float)(1.8);
            Math.Round(celcius,2);

            Console.Clear();
            Console.WriteLine($"A temperatue {fahrenheit} Fahrenheite é {celcius} Celcius.");
            Console.ReadKey();
        }
    }
}
