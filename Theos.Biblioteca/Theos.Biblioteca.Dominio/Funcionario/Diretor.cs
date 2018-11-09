using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SetorAlias = Theos.Biblioteca.Dominio.Setor.Setor;

namespace Theos.Biblioteca.Dominio.Funcionario
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf, SetorAlias setor)
            : base(nome, cpf, setor)
        {

        }

    }
}
