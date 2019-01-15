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

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
            Console.WriteLine("Alterar Endereco Cliente");
        }

        public string Nome { get; }
        public string Cpf { get; }
        public DateTime DataNascimento { get; }
        public string Endereco { get; private set; }

        public abstract  decimal SalarioFuncionario();

        public abstract void Gravar();
    }
}
