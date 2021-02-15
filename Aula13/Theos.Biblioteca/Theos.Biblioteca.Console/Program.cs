using System;
using Theos.Biblioteca.Dominio.Funcionario;
using Theos.Biblioteca.Dominio.Permissao;
using Theos.Biblioteca.Dominio.Setor;
using Theos.Biblioteca.Dominio.Setor.Enumerador;

namespace Theos.Biblioteca.Console
{
    class Program
    {
        static void Main(string[] args)
        {
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

            ESetor setorTeste = (ESetor)45;
            booleano = Enum.IsDefined(typeof(ESetor), setorTeste);

            Lider lider = new Lider("Lider", "45654345678", (ESetor)45);

            if (!string.IsNullOrWhiteSpace(lider.erro))
            {
                System.Console.WriteLine(lider.erro);
                System.Console.ReadKey();
                return;
            }

            permissoes = lider.GetPermissao();

            System.Console.ReadKey();
        }
    }
}
