using System;
using BibliotecaTheos.Dominio;
using BibliotecaTheos.Comum.Helpers;
using BibliotecaTheos.Dominio.Permissoes;
using BibliotecaTheos.Dominio.Setores;
using BibliotecaTheos.Dominio.Setores.Enumerador;
using BibliotecaTheos.Dominio.Funcionarios;

namespace BibliotecaTheos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biblioteca Theòs");

            Permissao permissao = new Permissao();

            permissao.PodeCadastrar();

            Setor setor = new Setor("Desenvolvimento");
            var permissoes = setor.GetPermissao();

            Desenvolvimento desenvolvimento = new Desenvolvimento();
            permissoes = desenvolvimento.GetPermissao();

            Suporte suporte = new Suporte();
            permissoes = suporte.GetPermissao();

            byte byteExemplo = 50;
            ESetor eSetor = (ESetor)byteExemplo;
            var booleano = Enum.IsDefined(typeof(ESetor), eSetor);

            Lider lider = new Lider("Lider", "45645645688", (ESetor)45);

            if (!string.IsNullOrWhiteSpace(lider.erro))
            {
                Console.WriteLine(lider.erro);
                Console.ReadKey();
                return
            }

            permissoes = lider.GetPermissao();
            Console.ReadKey();
        }
    }
}
