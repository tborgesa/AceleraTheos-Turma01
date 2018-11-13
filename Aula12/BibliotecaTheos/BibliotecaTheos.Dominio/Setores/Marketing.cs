using BibliotecaTheos.Dominio.Permissoes;
using System;

namespace BibliotecaTheos.Dominio.Setores
{
    class Marketing : Setor
    {
        public Marketing()
            : base("Marketing")
        {

        }

        public override Permissao GetPermissao()
        {
            Permissao permissao = base.GetPermissao();
            permissao.PodeAlterar();
            return permissao;
        }
    }
}
