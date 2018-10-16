using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, informe seu nome.");
            string nome = Console.ReadLine();


            Console.WriteLine($"Olá {nome}! por favor, informe seu filme favorito.");
            string filme = Console.ReadLine();
            filme = filme.ToUpper();

            Console.WriteLine($"Por favor, informe seu livro de cabeceira.");
            string livro = Console.ReadLine();
            livro = livro.ToUpper();

            Console.WriteLine($"Por favor, informe seu hobby preferido.");
            string hobby = Console.ReadLine();
            hobby = hobby.ToUpper();

            Console.WriteLine($"{nome}, o seu filme favorito é: {filme}, o livro: {livro}, e seu hobby: {hobby}.");

            Console.ReadKey();

        }
    }
}
