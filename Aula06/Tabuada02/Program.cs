using System;

namespace Tabuada02
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularTabuada();
            Console.ReadKey();
        }

        private static void CalcularTabuada()
        {
            Console.WriteLine("Digite um número para calcular a tabuada");
            string numero = Console.ReadLine();


            if (!int.TryParse(numero, out int numeroConvertido))
            {
                Console.WriteLine("Não é possível calcular a tabuada desse número, saia do sistema e digite novamente");
                return;
            }
            
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numeroConvertido * i;
                Console.WriteLine($"{numeroConvertido} x {i} = {resultado}");
            }
            
        }
    }
}
