using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Dominio.Pessoa
{
    public class ProfessorHorista : Professor
    {
        public ProfessorHorista(string nome, string cpf, string disciplina) : base(nome,cpf,disciplina)
        {

        }

        public override decimal SalarioProfessor()
        {

            decimal salario = (decimal)(horas * 17.00);

            return salario;
        }
    }
         
}
