using System;

/*
 5. Solicite ao usuário:
   - Filme Favorito?
   - Livro de Cabeceira?
   - Hobby Preferido?

Crie uma string que junte todas as informações e apresente para o usuário, colocando a identificação sempre maiuscula
Ex: FILME: Esqueceram de mim 2, LIBRO: Biblia, Hobby: Dormir
     */

namespace Exercicio05
{
    class Program
    {
        public static string caixaAlta(string text)
        {
            return text.Substring(0, text.IndexOf(":")).ToUpper();

        }

        static void Main(string[] args)
        {
            string teste = "filme: Esqueceram de mim 2, livro: Biblia, hobby: Dormir";


            var aux = teste.Split(',');

            for (int i = 0; i < aux.Length; i++)
            {
                aux[i].Substring(0, aux[i].IndexOf(":")).ToUpper();
                Console.WriteLine($"{caixaAlta(aux[i])}{aux[i].Substring(aux[i].IndexOf(":"))}");
            }
                       
            Console.ReadKey();

        }
    }
}
