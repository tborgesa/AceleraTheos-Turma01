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

        private DateTime DataNascimento;
        private string Cpf;
        private string Nome;
        public string Endereco;
    }
}