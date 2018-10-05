using System;

namespace Exercicio02_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            ref int numeroCopiado = ref numero;

            numeroCopiado += numeroCopiado;

            Console.WriteLine($"Numero: {numero}");
            Console.WriteLine($"Numero: {numeroCopiado}");

            Console.ReadKey();
        }
    }
}
