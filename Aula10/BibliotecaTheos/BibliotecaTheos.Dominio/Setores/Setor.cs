using System;
using BibliotecaTheos.Dominio.Permissoes;

namespace BibliotecaTheos.Dominio.Setores
{
    public class Setor
    {
        public string Nome { get; }

        public Setor(string nome, Permissao permissao)
        {
            Nome = nome;

        }

        public Permissao GetPermissao()
        {
            Permissao permissao = new Permissao();
            permissao.PodeDevolverLivro();
            return permissao;
        }
    }
}
