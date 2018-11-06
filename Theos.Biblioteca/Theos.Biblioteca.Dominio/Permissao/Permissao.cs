using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.Biblioteca.Dominio
{
    public class Permissao
    {
        public bool CadastrarLivro { get; private set; }
        public bool AlterarLivro { get; private set; }
        public bool ExcluirLivro { get; private set; }
        public bool FazerEmprestimo { get; private set; }
        public bool DevolverLivro { get; private set; }

        public void PodeCadastrar()
        {
          

        }

      
    }
}
