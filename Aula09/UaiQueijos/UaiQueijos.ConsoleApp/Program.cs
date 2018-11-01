using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UaiQueijos.Comum.Helpers;
using UaiQueijos.Dominio;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            InputHelper.mensagemUsuario("Projeto comum");

            var cliente = new Cliente(new System.DateTime(1987, 7, 8), 
                "012345678", 
                "Rafael");
            cliente.Endereco = "19 de dezembro, 369. Maringá - PR";

            var cliente1 = cliente;
            //cliente1.Nome = "thiago";nao pode pq nome é privado e só é usado no construtor

            Console.ReadKey();
        }
    }
}
