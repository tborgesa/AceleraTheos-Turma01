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

            //todo Thiago: Uma outra maneira já é declarar 0 1.8 como float (1.8f):
            //float celcius = (fahrenheit - 32) * 1.8f;

            //todo Thiago: Cuidado com errero de português nas variaveis e na mensagem para o usuário
            float celcius = (fahrenheit - 32) * (float)(1.8);
            Math.Round(celcius,2);

            Console.Clear();
            Console.WriteLine($"A temperatue {fahrenheit} Fahrenheite é {celcius} Celcius.");
            Console.ReadKey();
        }
    }
}
