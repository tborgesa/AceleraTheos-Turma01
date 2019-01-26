using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2.Dominio.Pessoa
{
    public abstract class Professor : Pessoa
    {
        public string Disciplina { get; private set; }
        public decimal Salario { get; private set; }

        public Professor(int codigo, string nome, string cpf, string disciplina, decimal salario) : base(codigo,nome, cpf)
        {
            Disciplina = disciplina;
            Salario = salario;
        }

        public abstract decimal SalarioProfessor(decimal salarioProfessor);
    }
}
