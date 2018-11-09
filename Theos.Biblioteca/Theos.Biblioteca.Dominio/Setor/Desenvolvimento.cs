using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Desenvolvimento : Setor
    {
        public Desenvolvimento()
            :base("Desenvolvimento") 

        {

        }


        public override Permissao GetPermissao()
        {
            Permissao permissao = new Permissao();
            permissao.PodeAlterar();

            return permissao;
        }
    }
}
