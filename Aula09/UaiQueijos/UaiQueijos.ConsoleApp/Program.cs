using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;
using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;
using ClienteGoldAlias = UaiQueijos.Dominio.Cliente.ClienteGold;
using ClienteSilverAlias = UaiQueijos.Dominio.Cliente.ClienteSilver;
using ProdutoAlias = UaiQueijos.Dominio.Produto.Produto;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHelper.mensagemUsuario("Projeto comum");

            ClienteAlias cliente = new ClienteAlias(new System.DateTime(1987, 7, 8), 
                "012345678", 
                "RafaelNormal");

            ClienteAlias clienteSilver = new ClienteSilverAlias(new System.DateTime(1987, 7, 8),
                 "012345678",
                  "RafaelSilver");

            //((ClienteSilverAlias)clienteSilver).;

            ClienteGoldAlias clienteGold = new ClienteGoldAlias(new System.DateTime(1987, 7, 8), 
                "012345678", 
                "RafaelGold");

            ProdutoAlias produto = new ProdutoAlias("Pao de Queijo",100,5);

            Pessoa sdadsa = new Pessoa();

            Console.WriteLine($"o preco é{produto.CalculaPrecoFinalProduto(cliente)}");
            Console.WriteLine($"o preco é{produto.CalculaPrecoFinalProduto(clienteSilver)}");
            Console.WriteLine($"o preco é{produto.CalculaPrecoFinalProduto(clienteGold)}");


            Console.ReadKey();
        }


    }
}
