using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.Pizzaria.Dominio.Cliente
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string cpf, string telefone, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }

        public void ValidarNome()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Preencha o nome do cliente");
        }

        public void ValidarCPF()
        {
            if (string.IsNullOrWhiteSpace(CPF))
                AdicionarErro("Preencha o CPF do cliente");
        }

        public void ValidarTelefone()
        {
            if (string.IsNullOrWhiteSpace(Telefone))
                AdicionarErro("Preencha o telefone do cliente");
        }

        public void ValidarDataNascimento()
        {
            if (DataNascimento < new DateTime(1900, 01, 01).Date)
                AdicionarErro("Data Inválida.");
        }
    }
}
