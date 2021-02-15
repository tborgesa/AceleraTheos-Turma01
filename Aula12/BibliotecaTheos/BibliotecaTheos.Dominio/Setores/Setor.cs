using System;
using BibliotecaTheos.Dominio.Permissoes;

namespace BibliotecaTheos.Dominio.Setores
{
    public class Setor
    {
        public string Nome { get; }

        public Setor(string nome)
        {
            Nome = nome;
        }

        public virtual Permissao GetPermissao()
        {
            Permissao permissao = new Permissao();
            permissao.PodeDevolver();
            return permissao;
        }
    }
}
