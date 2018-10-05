using System;

namespace Exercicio01_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            int numeroCopiado = numero;

            numeroCopiado += numeroCopiado;

            Console.WriteLine($"Numero: {numero}");
            Console.WriteLine($"Numero: {numeroCopiado}");

            Console.ReadKey();
        }
    }
}
