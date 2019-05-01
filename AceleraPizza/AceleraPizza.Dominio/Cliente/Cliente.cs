using AceleraPizza.Comum.Helpers;
using System;

namespace AceleraPizza.Dominio.Cliente
{
    public class Cliente : Entidade
    {
        public Cliente() { }

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

            ValidaAlteracao(this.Endereco, this.Telefone);

            if (!CpfHelper.CpfValido(Cpf))
                AdicionarErro("CPF inválido.");

            if (DataNascimento < new DateTime(1900, 01, 01).Date)
                AdicionarErro("Data Inválida.");
        }

        private void ValidaAlteracao(string endereco, string telefone)
        {
            if (string.IsNullOrWhiteSpace(endereco))
                AdicionarErro("Preencha o endereço.");

            if (string.IsNullOrWhiteSpace(telefone))
            {
                AdicionarErro("Preencha o telefone.");
            }
            else if (telefone.Length < 8 | telefone.Length > 10){
                AdicionarErro("Telefone inválido."); }
        }

        public void AlterarEndereco(ClienteAtualizarViewModel clienteAtualizarViewModel)
        {
            ValidaAlteracao(clienteAtualizarViewModel.Endereco, clienteAtualizarViewModel.Telefone);
            Endereco = clienteAtualizarViewModel.Endereco;
            Telefone = clienteAtualizarViewModel.Telefone;
        }

        public override Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
    }
}
