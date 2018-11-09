using System;

namespace UaiQueijos.Dominio.Cliente
{
    public class ClienteSilver : Cliente
    {
        public ClienteSilver(DateTime dataNascimento, string nome, string cpf)
            : base(dataNascimento, nome, cpf)
        {
            
        }

        public ClienteSilver(DateTime dataNascimento, string nome, string cpf, string endereco)
            : base (dataNascimento, nome, cpf, endereco)
        {
            
        }

        public override double ObterDesconto(double descontoPadrao)
        {
            return base.ObterDesconto(descontoPadrao)*2;
        }

        public override string ToString()
        {
            return $"{Nome} - {Cpf} - Silver";
        }
    }
}
