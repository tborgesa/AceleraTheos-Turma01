using System;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;
using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;
using ProdutoAlias = UaiQueijos.Dominio.Produto.Produto;
namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHelper.MensagemUsuario("Acessando o comum");

            ClienteAlias cliente = new ClienteAlias(new DateTime(1994, 7, 29), "42120768889", "Caroline", "Rua Urano, 229 - Jd Imperial II");


            ProdutoAlias produto = new ProdutoAlias("Pão de quejo", 35, 5);

            Console.ReadKey();
        }
    }
}
