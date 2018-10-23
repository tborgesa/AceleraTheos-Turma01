using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Solicite um numero de 1 a 10 ao usuário e calcule a tabuada desse número.*/

            Console.WriteLine("Digite um número de 1 a 10 para ser calculado a tabuada:");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} * {i} = {numero * i}");                
            }

            Console.ReadKey();
        }
    }
}
