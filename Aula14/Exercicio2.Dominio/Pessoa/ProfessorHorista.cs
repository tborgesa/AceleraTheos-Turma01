using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Dominio.Pessoa
{
    public class ProfessorHorista : Professor
    {
        public ProfessorHorista(int codigo, string nome, string cpf, string disciplina, decimal salario) : base(codigo, nome,cpf,disciplina,salario)
        {

        }

        public override decimal SalarioProfessor(decimal horasTrabalhadas)
        {
            horasTrabalhadas=0;
            decimal salario = (decimal)horasTrabalhadas * 17.0m;
            salario = Salario;
            return salario;
        }
    }
         
}
