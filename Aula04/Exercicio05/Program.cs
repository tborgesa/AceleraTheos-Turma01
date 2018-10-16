using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            string filme, livro, hobby;

            Console.WriteLine("Filme favorito?");
            filme = Console.ReadLine();

            Console.WriteLine("Livro de cabeceira?");
            livro = Console.ReadLine();

            Console.WriteLine("Hobby preferido?");
            hobby = Console.ReadLine();
    
            Console.WriteLine($"Filme: {filme.ToUpper()}, Livro: {livro.ToUpper()}, Hobby: {hobby.ToUpper()}");
            Console.ReadKey();
        }
    }
}
