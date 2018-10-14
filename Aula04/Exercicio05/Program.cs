using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Solicite ao usuário:
            //-Filme Favorito ?
            //-Livro de Cabeceira ?
            //-Hobby Preferido ?
            //Crie uma string que junte todas as informações e apresente para o usuário, colocando a identificação sempre maiuscula
            //Ex: FILME: Esqueceram de mim 2, LIBRO: Biblia, Hobby: Dormir

            string filme,livro,hobby;

            Console.WriteLine("Qual seu filme favorito ?");
            filme = Console.ReadLine();
            Console.WriteLine("Qual seu livro de cabeceira ?");
            livro = Console.ReadLine();
            Console.WriteLine("Qual seu hobby favorito ?");
            hobby = Console.ReadLine();

            Console.WriteLine($"FILME: {filme.ToUpper()}, LIVRO: {livro.ToUpper()} e HOBBY: {hobby.ToUpper()}");

            Console.ReadKey();
        }
    }
}
