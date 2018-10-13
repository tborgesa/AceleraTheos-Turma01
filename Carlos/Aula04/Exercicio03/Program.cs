using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Volte ao exercicio 2 da aula anterior e formate a temperatura apresentando sempre 2 casas decimais.
            
            Console.WriteLine("Informe a temperatura em Fahrenheit:");
            float temperaturaF = float.Parse(Console.ReadLine());

            var temperaturaC = ((temperaturaF - 32) / 1.8);

            Console.WriteLine($"\nA temperatura em Celsius é {temperaturaC:n2}.");

            Console.ReadKey();
        }
    }
}
