using System;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //3.Volte ao exercicio 2 da aula anterior e formate a temperatura apresentando sempre 2 casas decimais.
            Console.WriteLine("Informe a temperatura em °F");
            double temperaturaF = Convert.ToDouble(Console.ReadLine());

            double temperaturaC = (temperaturaF - 32) / 1.8;
            Console.WriteLine($"{Math.Round(temperaturaF, 2)}°F é igual a {Math.Round(temperaturaC, 2)}°C.");


            // 4.Volte ao exercicio 5 da aula anterior e formate o salário apresentando sempre 2 casas decimai
            Console.WriteLine("Qual o nome do funcionário?");
            string funcionario = Console.ReadLine();

            Console.WriteLine($"Qual é o salário atual do(a) {funcionario}");
            double salario = Convert.ToDouble(Console.ReadLine());

            double ajuste = (salario * 5) / 100;
            salario = salario + ajuste;

            Console.WriteLine($"O salário do(a) {funcionario} recebeu um ajuste de R${Math.Round(ajuste, 2)} e agora corresponde a R${Math.Round(salario, 2)}");
            */

            /* 5.Solicite ao usuário: -Filme Favorito, -Livro de Cabeceira, -Hobby Preferido
            Crie uma string que junte todas as informações e apresente para o usuário, colocando a identificação sempre maiuscula
            Ex: FILME: Esqueceram de mim 2, LIBRO: Biblia, Hobby: Dormir*/
            Console.WriteLine("Qual é seu filme favorito?");
            string filme = Console.ReadLine().ToUpper();

            Console.WriteLine("Qual é seu livro de Cabeceira?");
            string livro = Console.ReadLine().ToUpper();

            Console.WriteLine("Qual é seu hobby predileto?");
            string hobby = Console.ReadLine().ToUpper();

            Console.WriteLine();
            Console.WriteLine("Preferências do usuário");
            Console.Write($"Filme: {filme}, Livro: {livro} e Hobby: {hobby}.");

            Console.ReadKey();
        }


    }
}

