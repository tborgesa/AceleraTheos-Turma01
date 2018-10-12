using System;


namespace EnderecoEx02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o rua, bairro e cidade separados por vírgula");

            string enderecoCompleto = Console.ReadLine();

            string rua = enderecoCompleto.Substring(0, enderecoCompleto.IndexOf(','));
            Console.WriteLine($"Rua: {rua}");

            string restoEndereco = enderecoCompleto.Substring(rua.Length + 1);

            string bairro = restoEndereco.Substring(0, restoEndereco.IndexOf(','));
            Console.WriteLine($"Bairro: {bairro}");

            string cidade = restoEndereco.Substring(bairro.Length + 1);
            Console.WriteLine($"Cidade: {cidade}");
            Console.ReadKey();
        }
    }
}
