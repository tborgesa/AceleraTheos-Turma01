using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiQueijos.Dominio
{
    public abstract class Pessoa
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

        public DateTime DataNascimento { get; }
        public string Cpf { get; }
        public string Nome { get; }
        public string Endereco { get; private set; }


        public void AlterarEndereco(string endereco)
        {
            Endereco = endereco;
        }
    }
}
