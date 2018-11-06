using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Setor
    {
        public string Nome { get; set; }

        public virtual Permissao GetPermissao()
        {
            var permissao = new Permissao();

            permissao.AlterarLivro
        }
    }
}
