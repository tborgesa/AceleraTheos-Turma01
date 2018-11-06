using System;

namespace UaiQueijos.Dominio.Cliente
{
    public class ClienteSilver : Cliente
    {
        public ClienteSilver(DateTime dataNascimento, string cpf, string nome)
         : base(dataNascimento, cpf, nome)
        {

        }

        public ClienteSilver(DateTime dataNascimento, string cpf, string nome, string endereco)
         : base(dataNascimento, cpf, nome)
        {

        }

        public override double ObterDesconto(double descontoPadrao)
        {
            return base.ObterDesconto(descontoPadrao) * 1.5;
        }

        public void EspecificoSilver()
        {

        }

    }
}
