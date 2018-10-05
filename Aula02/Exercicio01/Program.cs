using System;

namespace Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome.");
            string nome = Console.ReadLine();
            Console.WriteLine($"Seja bem-vindo {nome}, bem vindo novamente {nome}");
            Console.ReadKey();
        }
    }
}
