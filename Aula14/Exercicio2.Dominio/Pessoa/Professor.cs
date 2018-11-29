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

        public Professor(string nome, string cpf, string disciplina) : base(nome, cpf)
        {
            Disciplina = disciplina;
        }

        public abstract decimal SalarioProfessor();
    }
}
