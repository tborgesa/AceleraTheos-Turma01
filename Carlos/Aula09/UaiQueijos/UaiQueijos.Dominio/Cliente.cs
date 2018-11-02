using System;

namespace UaiQueijos.Dominio
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

        public string Nome { get; }
        public string Cpf { get; }
        public DateTime DataNascimento { get; }
        public string Endereco { get; private set; }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
        }
    }
}