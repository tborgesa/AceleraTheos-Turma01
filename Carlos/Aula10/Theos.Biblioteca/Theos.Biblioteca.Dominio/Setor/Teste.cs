using System;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Teste : Setor
    {
        public Teste()
            : base ("Teste")
        {

        }

        public override Permissao GetPermissao()
        {
            Permissao permissao = base.GetPermissao();
            permissao.PermissaoExcluir();
            return permissao;
        }
    }
}
