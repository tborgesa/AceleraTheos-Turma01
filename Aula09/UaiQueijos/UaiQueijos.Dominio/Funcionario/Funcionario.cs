using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiQueijos.Dominio.Funcionario
{
    public class Funcionario : Pessoa
    {
        public Funcionario(DateTime dataNascimento, string cpf, string nome) : base(dataNascimento, cpf, nome)
        {
        }

        public Funcionario(DateTime dataNascimento, string cpf, string nome, string endereco) : base(dataNascimento, cpf, nome, endereco)
        {
        }
    }
}
