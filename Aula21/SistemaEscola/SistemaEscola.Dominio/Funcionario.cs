using System;
using System.Collections.Generic;
using SistemaEscola.Comum.Helpers;

namespace SistemaEscola.Dominio.Funcionario
{
    public abstract class Funcionario : Entidade
    {

        public Funcionario(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;

            Validar();
        }

        public Funcionario(string nome, string cpf, DateTime dataNascimento, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Endereco = endereco;

            Validar();
        }

        //Este construtor só se justifica pois estamos deserializando e a biblioteca de serialização precisa de um costrutor
        //vazio para por instanciar.
        public Funcionario()
        {

        }

        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
        }

        private void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Preencha o nome.");

            if (!CpfHelper.CpfValido(Cpf))
                AdicionarErro("CPF inválido.");

            if (DataNascimento < new DateTime(1900, 01, 01).Date)
                AdicionarErro("Data Inválida.");
        }

        public override string ToString()
        {
            return $"{Nome} - {Cpf}";
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public abstract decimal SalarioFuncionario();

        public abstract void Gravar();
    }
}
