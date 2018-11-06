using System;

namespace UaiQueijos.Dominio.Cliente
{
    public class Cliente
    {
        public Cliente(DateTime dataNascimento, string cpf, string nome)
        {
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Nome = nome;
        }

        public Cliente(DateTime dataNascimento, string cpf, string nome, string endereco)
        {
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Nome = nome;
            Endereco = endereco;
        }

        private DateTime DataNascimento { get; }
        private string Cpf { get; }
        private string Nome { get; }
        public string Endereco { get; private set; }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public virtual double ObterDesconto(double descontoPadrao)
        {
            return descontoPadrao;
        }

    }
}
