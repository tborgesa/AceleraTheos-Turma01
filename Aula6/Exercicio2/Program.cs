using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Solicite um numero de 1 a 10 ao usuário e calcule a tabuada desse número.

            Console.WriteLine("Informe um número para ser exibida a tabuada.");
            string numero = Console.ReadLine();


            if (!int.TryParse(numero, out var numeroInteiro))
            {
                Console.WriteLine("por favor, informe um número válido!");
                Console.ReadKey();
                return;
            }

            for (int i = 1; i <= 10; i++)
            {
                int resultado = (i * numeroInteiro);
                Console.WriteLine($"{i} X {numeroInteiro} = {resultado}");
            }

            Console.ReadKey();
        }
    }
}
