using System;
using Theos.Biblioteca.Comum;

namespace Theos.Biblioteca.Dominio
{
    public class Funcionario
    {
        public Funcionario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public string Nome { get; }
        public string Cpf { get; }
    }
}
