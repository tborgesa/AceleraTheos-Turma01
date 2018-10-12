using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, informe seu filme favorito.");
            string filme = Console.ReadLine();
            filme = filme.ToUpper();

            Console.WriteLine("Por favor, informe seu livro de cabeceira.");
            string livro = Console.ReadLine();
            livro = livro.ToUpper();

            Console.WriteLine("Por favor, informe seu hobby preferido.");
            string hobby = Console.ReadLine();
            livro = livro.ToUpper();

            Console.WriteLine($"Filme :{filme}, Livro: {livro}, Hobby: {hobby}.");

            Console.ReadKey();

        }
    }
}
