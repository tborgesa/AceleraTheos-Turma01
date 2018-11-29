using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Dominio.Pessoa
{
    public class ProfessorContratado : Professor
    {
        public ProfessorContratado(string nome, string cpf, string disciplina) : base(nome, cpf, disciplina)
        {

        }

        public override decimal SalarioProfessor()
        {
            throw new NotImplementedException();    
        }

    }
}
