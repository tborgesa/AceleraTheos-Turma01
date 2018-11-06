using System;

namespace UaiQueijos.Dominio
{
    public class Pessoa
    {
        public Pessoa(DateTime dataNascimento, string cpf, string nome)
        {
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Nome = nome;
        }

        public Pessoa(DateTime dataNascimento, string cpf, string nome, string endereco)
        {
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Nome = nome;
            Endereco = endereco;
        }

        public string Nome { get; }
        public string Cpf { get; }
        public DateTime DataNascimento { get; }
        public string Endereco { get; private set; }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
        }

        // virtual : todo mundo que herda pode alterar
        public virtual double ObeterDesconto(double descontoPadrao)
        {
            return descontoPadrao;
        }
    }
}