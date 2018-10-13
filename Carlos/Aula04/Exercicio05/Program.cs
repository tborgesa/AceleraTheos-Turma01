using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*5. Solicite ao usuário:
            -Filme Favorito ?
            -Livro de Cabeceira ?
            -Hobby Preferido ?

            Crie uma string que junte todas as informações e apresente para o usuário, colocando a identificação sempre maiuscula
            Ex: FILME: Esqueceram de mim 2, LIBRO: Biblia, Hobby: Dormir*/

            string filme,
                   livro,
                   hobby,
                   stringCompleta;

            Console.WriteLine("Qual seu filme favorito?");
            filme = Console.ReadLine();
            Console.WriteLine("\nQual seu livro de cabeceira?");
            livro = Console.ReadLine();
            Console.WriteLine("\nQual seu hobby favorito?");
            hobby = Console.ReadLine();

            stringCompleta = "FILME: " + filme + " " + "LIVRO: " + livro + " " + "HOBBY: " + hobby;

            Console.WriteLine($"\n{stringCompleta}");

            Console.ReadKey();
        }
    }
}
