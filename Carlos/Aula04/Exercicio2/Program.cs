using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Peça para o usuário digitar o endereço completo (Rua, Bairro e Cidade) separados por ',' e apresente para ele cada item separado.

            string enderecoCompleto;

            Console.WriteLine("Digite o endereço completo (logradouro, Bairro e cidade) separado por virgula:");
            enderecoCompleto = "logradouro,Bairro,cidade";
            //enderecoCompleto = Console.ReadLine();

            var aux = enderecoCompleto.IndexOf(",") + 1;
            var restoString = enderecoCompleto.Substring(aux);

            Console.WriteLine($"\nLogradouro: {enderecoCompleto.Substring(0, enderecoCompleto.IndexOf(","))}");
            Console.WriteLine($"\nbairro: {restoString.Substring(0, restoString.IndexOf(","))}");
            Console.WriteLine($"\nCidade: {enderecoCompleto.Substring(enderecoCompleto.LastIndexOf(",") + 1)}");


            Console.ReadKey();

        }
    }
}
