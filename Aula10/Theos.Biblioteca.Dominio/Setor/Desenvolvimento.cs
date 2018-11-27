using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PermissaoAlias = Theos.Biblioteca.Dominio.Permissao.Permissao;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Desenvolvimento : Setor
    {
        public Desenvolvimento()
            : base("Desenvolvimento")
        {

        }

        public override PermissaoAlias GetPermissao()
        {
            PermissaoAlias permissao = base.GetPermissao();
            permissao.PodeEmprestar() ;
            return permissao;
        }
    }
}
