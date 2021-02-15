using System;


namespace UaiQueijos.Dominio
{
    public class Cliente
    {
        public Cliente(DateTime dataNascimento, string nome, string cpf)
        {
            DataNascimento = dataNascimento;
            Nome = nome;
            Cpf = cpf;
        }

        private DateTime DataNascimento;
        private string Cpf;
        private string Nome;
        public string Endereco;
    }

}
