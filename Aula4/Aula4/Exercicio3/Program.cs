using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Volte ao exercicio 2 da aula anterior e formate a temperatura apresentando sempre 2 casas decimais.

            Console.WriteLine("por favor, Informe a temperatura em graus Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = ((fahrenheit - 32) * 5) / 9;
            Console.WriteLine($"a temperatura em graus Celsius é de {celsius:n2} graus.");


            Console.ReadKey();
        }
    }
}
