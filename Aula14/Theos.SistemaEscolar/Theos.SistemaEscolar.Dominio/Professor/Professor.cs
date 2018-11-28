
using System.Collections.Generic;

namespace Theos.SistemaEscolar.Dominio.Professor
{
    public abstract class Professor
    {

        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        public Professor(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public Professor()
        {

        }
        public abstract decimal CalcularSalario();


    }
}
