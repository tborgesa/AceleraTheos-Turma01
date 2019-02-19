using System;
using UaiQueijos.Comum.Helpers;

namespace UaiQueijos.Dominio
{
    public abstract class Pessoa : Entidade
    {
        public Pessoa()
        {

        }

        public Pessoa(DateTime dataNascimento, string cpf, string nome)
        {
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Nome = nome;
            Validar();
            
        }

        public Pessoa(DateTime dataNascimento, string cpf, string nome, string endereco)
        {
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Nome = nome;
            Endereco = endereco;
            Validar();
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;

            if (string.IsNullOrEmpty(endereco))
                AdicionarErro("Na alteração o endereço é obrigatório.");
        }

        public abstract string CriarEmail();

        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Preencha o nome.");

            if (!Cpf.CpfValido())
                AdicionarErro("CPF inválido.");

            if (DataNascimento < new DateTime(1900,01,01).Date)
                AdicionarErro("Data Inválida.");
        }

        public override string ToString()
        {
            return $"{Nome} - {Cpf}";
        }
    }
}