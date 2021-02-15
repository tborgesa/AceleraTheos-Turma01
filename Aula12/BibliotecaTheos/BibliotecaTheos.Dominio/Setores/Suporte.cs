using System;
using BibliotecaTheos.Dominio.Permissoes;

namespace BibliotecaTheos.Dominio.Setores
{
    public class Suporte : Setor
    {
        public Suporte()
            :base("Suporte")
        {

        }

            public override Permissao GetPermissao()
        {
            Permissao permissao = base.GetPermissao();
            permissao.PodeAlterar();
            return base.GetPermissao();
        }

    }
}
