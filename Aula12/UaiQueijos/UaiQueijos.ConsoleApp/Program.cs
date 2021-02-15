using System;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;
using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHelper.MensagemUsuario("Acessando diretamente um projeto Comum.");

            ClienteAlias cliente = new ClienteAlias(new DateTime(1987, 07, 24), 
                "07365412345", 
                "Talita");

            ClienteAlias cliente2 = new ClienteAlias(new DateTime(1987, 07, 24), 
                "07365412345", 
                "Talita",
                "Rua Castro Alves, 1390. Maringá - PR");

            ClienteAlias cliente1 = cliente;
            
            //todo instanciar novo cliente

            Console.ReadKey();
        }
    }
}
