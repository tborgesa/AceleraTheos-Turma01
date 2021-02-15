using System;
using BibliotecaTheos.Dominio.Permissoes;

namespace BibliotecaTheos.Dominio.Setores
{
    class Dba : Setor
    {
        public Dba()
            :base("Dba")
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
