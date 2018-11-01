using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
