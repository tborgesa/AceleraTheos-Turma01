using System;


namespace UaiQueijos.Dominio.Cliente

{
    public class Cliente
    {
        public Cliente(DateTime dataNascimento, string nome, string cpf)
        {
            DataNascimento = dataNascimento;
            Nome = nome;
            Cpf = cpf;
        }

        public Cliente(DateTime dataNascimento, string nome, string cpf, string endereco)
        {
            DataNascimento = dataNascimento;
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }

        private string Nome { get; }
        public DateTime DataNascimento { get; }
        public string Cpf { get; }
        public string Endereco { get; private set; }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
        }

    }

}
