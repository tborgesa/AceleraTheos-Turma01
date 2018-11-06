using System;
using Theos.Biblioteca.Comum;

namespace Theos.Biblioteca.Dominio
{
    public class Funcionario
    {
        public Funcionario(string nome, string cpf, string setor)
        {
            Nome = nome;
            Cpf = cpf;
            Setor = setor;
        }

        public string Nome { get; }
        public string Cpf { get; }
        public string Setor { get; private set; }

        public void AlterarSetor(string setor)
        {
            Setor = setor;
        }
    }
}
