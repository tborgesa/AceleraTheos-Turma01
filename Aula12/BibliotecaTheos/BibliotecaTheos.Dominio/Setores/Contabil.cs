using System;
using BibliotecaTheos.Dominio.Permissoes;

namespace BibliotecaTheos.Dominio.Setores
{
    public class Contabil : Setor
    {
        public Contabil()
            : base("Contábil")
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
