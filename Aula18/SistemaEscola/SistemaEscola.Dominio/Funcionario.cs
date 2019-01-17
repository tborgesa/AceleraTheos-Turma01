using System;
using System.Collections.Generic;

namespace SistemaEscola.Dominio.Funcionario
{
    public abstract class Funcionario : Entidade
    {
        public Funcionario(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;

            ValidaNome();

            if (string.IsNullOrWhiteSpace(nome))
            {
                AdicionarErro("");
            }

        }

        public Funcionario(string nome, string cpf, DateTime dataNascimento, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;

            ValidaNome();
        }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
            Console.WriteLine("Alterar Endereco Cliente");
        }

        public List<string> GetErros()
        {
            return _erros;
        }

        public void ValidaNome()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Preencha o Nome");
        }


        public string Nome { get; }
        public string Cpf { get; }
        public DateTime DataNascimento { get; }
        public string Endereco { get; private set; }
        private List<string> _erros = new List<string>();

        public abstract  decimal SalarioFuncionario();

        public abstract void Gravar();
    }
}
