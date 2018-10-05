using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plataforma .NET");

            Console.WriteLine("Digite seu nome.");
            string nome = Console.ReadLine();

            //Três formas de montar string e apresentar pawra o usuário.
            Console.WriteLine("Seja bem vindo, " + nome + ".");
            Console.WriteLine(string.Format($"Seja bem vindo, {0}.", nome));
            Console.WriteLine($"Seja bem vindo, {nome}.");

            Console.ReadKey();
        }        
    }
}
