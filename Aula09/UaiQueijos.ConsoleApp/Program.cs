using System;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHelper.MensagemUsuario("Acessando diretamente um projeto Comum.");

            Cliente cliente = new Cliente(new DateTime(1987, 07, 24), "07365412345", "Talita");
            cliente.Endereco = "Rua Castro Alves, 1390. Maringá - PR";

            Cliente cliente1 = cliente;

            Console.ReadKey();
        }
    }
}
