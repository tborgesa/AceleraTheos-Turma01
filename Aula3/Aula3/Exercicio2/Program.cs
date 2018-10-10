using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Converter a temperatura em graus Fahrenheit para graus Celsius.
            //Fahrenheit para Celsius: (oF – 32) x 5) / 9

            Console.WriteLine("por favor, Informe a temperatura em graus Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = ((fahrenheit - 32) * 5) / 9;
            celsius = Math.Round(celsius, 2);
            Console.WriteLine($"a temperatura em graus Celsius é de {celsius} graus.");


            Console.ReadKey();
        }
    }
}
