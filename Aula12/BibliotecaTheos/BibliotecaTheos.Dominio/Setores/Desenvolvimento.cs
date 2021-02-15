using System;
using BibliotecaTheos.Dominio.Permissoes;

namespace BibliotecaTheos.Dominio.Setores
{
    public class Desenvolvimento : Setor
    {
        public Desenvolvimento()
            :base("Desenvolvimento")
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
