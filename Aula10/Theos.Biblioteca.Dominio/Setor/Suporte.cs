using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PermissaoAlias = Theos.Biblioteca.Dominio.Permissao.Permissao;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Suporte : Setor
    {
        public Suporte()
            : base("Suporte")
        {

        }

        public override PermissaoAlias GetPermissao()
        {
            return base.GetPermissao();
            
        }
    }
}
