using System;

namespace SistemaEscola.Dominio.Funcionario
{
    public abstract class Funcionario : Entidade
    {
        public Funcionario(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public Funcionario(string nome, string cpf, DateTime dataNascimento, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }

        public string Nome { get; }
        public string Cpf { get; }
        public DateTime DataNascimento { get; }
        public string Endereco { get; private set; }

        public abstract  decimal SalarioFuncionario();

        public abstract void Gravar();

        public void GerarId()
        {
            throw new NotImplementedException();
        }
    }
}
