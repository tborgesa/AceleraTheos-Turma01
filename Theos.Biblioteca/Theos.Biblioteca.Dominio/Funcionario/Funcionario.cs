using System;
using SetorAlias = Theos.Biblioteca.Dominio.Setor.Setor;

namespace Theos.Biblioteca.Dominio.Funcionario
{
   public class Funcionario
    {
        public Funcionario(string nome, string cpf, SetorAlias setor)
        {
            Nome = nome;
            Cpf = cpf;
            Setor = setor;
        }

        public string Nome { get; }
        public string Cpf { get; }
        public SetorAlias Setor { get; }
    }
}
