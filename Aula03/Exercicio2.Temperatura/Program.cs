using System;

namespace Exercicio2.Temperatura
{
    class Program
    {
        //2. Converter a temperatura em graus Fahrenheit para graus Celsius.
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = ((fahrenheit - 32) * 5) / 9;
            celsius = Math.Round(celsius, 1);
            Console.WriteLine($"A temperatura em Celsius é de {celsius}°.");

            Console.ReadKey();
        }
    }
}
