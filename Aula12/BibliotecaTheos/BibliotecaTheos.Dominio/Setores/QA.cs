using System;
using BibliotecaTheos.Dominio.Permissoes;

namespace BibliotecaTheos.Dominio.Setores
{
    public class QA : Setor
    {
        public QA()
            :base("QA")
        {

        }
        public override Permissao GetPermissao()
        {
            Permissao permissao = base.GetPermissao();
            permissao.PodeExcluir();
            return base.GetPermissao();
        }
    }
}
