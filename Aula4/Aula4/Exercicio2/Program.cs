using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Peça para o usuário digitar o endereço completo (Rua, Bairro e Cidade) separados por ',' e apresente para ele cada item separado.

            Console.WriteLine("Por favor, informe seu endereço completo separado por vírgula (Rua, Bairro, Cidade).");
            string enderecoCompleto = Console.ReadLine();


            string rua = enderecoCompleto.Substring(0, enderecoCompleto.IndexOf(","));
            Console.WriteLine($"Rua: {rua}");

            int i = enderecoCompleto.IndexOf(",");
            string bairroCidade = enderecoCompleto.Substring(i + 1);
            string bairro = bairroCidade.Substring(0, bairroCidade.LastIndexOf(","));
            Console.WriteLine($"Bairro: {bairro}");

            int i1 = bairroCidade.IndexOf(",");
            string cidade = bairroCidade.Substring(i1 + 1);
            Console.WriteLine($"Cidade: {cidade}");


            Console.ReadKey();

        }
    }
}
