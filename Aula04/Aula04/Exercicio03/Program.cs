using System;

/*
*   Converter a temperatura em graus Fahrenheit para graus Celsius.
    3. Volte ao exercicio 2 da aula anterior e formate a temperatura apresentando sempre 2 casas decimais.
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
            Math.Round(celcius, 2);

            Console.Clear();
            Console.WriteLine($"A temperatue {fahrenheit:f2} Fahrenheite é {celcius:f2} Celcius.");

            Console.ReadKey();
        }
    }
}
