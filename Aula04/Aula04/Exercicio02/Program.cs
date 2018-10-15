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
            //***Com Split***
            /*
            Console.WriteLine("Digite o endereço completo (Rua, Bairro e Cidade) separados por ',' ");
            string endereco = Console.ReadLine();

            var aux = endereco.Split(',');

            Console.WriteLine($"Sua rua é {aux[0]}, no bairro {aux[1]}, na cidade de {aux[2]}");

            Console.ReadKey();
            */

            Console.WriteLine("Digite o endereço completo (Rua, Bairro e Cidade) separados por ',' ");
            string endereco = Console.ReadLine();
//            string endereco = "Rua José Clemente, Zona 07, Maringá";

            Console.WriteLine($"Sua rua é {endereco.Substring(0, endereco.IndexOf(','))}");
            Console.WriteLine($"Seu bairo é {endereco.Substring(endereco.IndexOf(",")+2,(endereco.LastIndexOf(",") - endereco.IndexOf(",")) - 2)}");
            Console.WriteLine($"Sua cidade é {endereco.Substring(endereco.LastIndexOf(",")+2)}");
            Console.ReadKey();
        }
    }
}
