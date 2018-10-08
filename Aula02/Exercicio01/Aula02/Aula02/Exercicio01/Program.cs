using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Nome");
            var nome = Console.ReadLine();
            Console.WriteLine($"Hello Moto {nome} !");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
