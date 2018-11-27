using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UaiQueijos.Dominio.Cliente
{
    public class ClienteSilver : Cliente
    {
        public ClienteSilver(DateTime dataNascimento, string cpf, string nome)
            : base(dataNascimento, cpf, nome)
        {

        }

        public ClienteSilver(DateTime dataNascimento, string cpf, string nome, string endereco)
            : base(dataNascimento, cpf, nome, endereco)
        {

        }

        public override double ObterDesconto(double descontoPadrao)
        {
            return base.ObterDesconto(descontoPadrao) * 1.5;
        }

    }
}
