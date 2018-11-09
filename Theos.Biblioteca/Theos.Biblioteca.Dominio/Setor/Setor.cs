using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Setor
    {
        public Setor(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; }

        public virtual Permissao GetPermissao()
        {
            var permissao = new Permissao();

            permissao.PodeDevolver();

            return permissao;
        }
    }
}
