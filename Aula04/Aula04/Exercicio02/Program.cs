using System;

/*
2. Peça para o usuário digitar o endereço completo(Rua, Bairro e Cidade) separados por ',' e apresente para ele cada item separado.
*/

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o endereço completo (Rua, Bairro e Cidade) separados por ',' ");
            string endereco = Console.ReadLine();

            var aux = endereco.Split(',');

            Console.WriteLine($"Sua rua é {aux[0]}, no bairro {aux[1]}, na cidade de {aux[2]}");

            Console.ReadKey();
        }
    }
}
