using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiQueijos.Dominio.Cliente
{
    public class Cliente : Pessoa
    {
        public Cliente(DateTime dataNascimento, string cpf, string nome)
            : base(dataNascimento, cpf, nome)
        {

        }

        public Cliente(DateTime dataNascimento, string cpf, string nome, string endereco)
            : base(dataNascimento, cpf, nome, endereco)
        {

        }

        public virtual double ObterDesconto(double descontoPadrao)
        {
            return descontoPadrao * 1.1;
        } 

    }
}
