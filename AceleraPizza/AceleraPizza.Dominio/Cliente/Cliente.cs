using AceleraPizza.Comum.Helpers;
using System;

namespace AceleraPizza.Dominio.Cliente
{
    public class Cliente : Entidade
    {
        public Cliente() { }

        //Sobrepor para não atrapalhar para quando instanciar
        public Cliente(string nome, string cpf, DateTime dataNascimento, string endereco, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Telefone = telefone;

            Validar();
        }

        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Preencha o nome.");

            if (string.IsNullOrWhiteSpace(Endereco))
                AdicionarErro("Preencha o endereço.");

            if (string.IsNullOrWhiteSpace(Telefone))
                AdicionarErro("Preencha o telefone.");

            if (Telefone.Length < 8 | Telefone.Length > 10)
                AdicionarErro("Telefone inválido.");

            if (!CpfHelper.CpfValido(Cpf))
                AdicionarErro("CPF inválido.");

            if (DataNascimento < new DateTime(1900, 01, 01).Date)
                AdicionarErro("Data Inválida.");
        }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public void AlterarTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public override Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
