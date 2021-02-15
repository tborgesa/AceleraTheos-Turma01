using BibliotecaTheos.Dominio.Permissoes;
using System;

namespace BibliotecaTheos.Dominio.Setores
{
    class Implantacao : Setor
    {
        public Implantacao()
            :base("Implantação")
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
