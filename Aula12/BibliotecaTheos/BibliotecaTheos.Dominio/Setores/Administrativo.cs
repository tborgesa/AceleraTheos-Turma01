using System;
using BibliotecaTheos.Dominio.Permissoes;

namespace BibliotecaTheos.Dominio.Setores
{
    class Administrativo : Setor
    {
        public Administrativo()
            : base("Administrativo")
        {

        }

        public override Permissao GetPermissao()
        {
            Permissao permissao =  base.GetPermissao();
            permissao.PodeAlterar();
            return permissao;
        }


    }
}
