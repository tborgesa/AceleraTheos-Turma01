using System;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");
            Console.WriteLine("por favor, informe seu Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"O nome digitado é {nome}");
            Console.ReadKey();
        }
    }
}
