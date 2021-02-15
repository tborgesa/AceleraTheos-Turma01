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

        public string Nome { get; }
        public DateTime DataNascimento { get; }
        public string Cpf { get; }
        public string Endereco { get; private set; }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public virtual double ObterDesconto(double descontopadrao)
        {
            return descontopadrao * 1.1;
        }

        public override string ToString()
        {
            return $"{Nome} - {Cpf}";
        }
    }

}
