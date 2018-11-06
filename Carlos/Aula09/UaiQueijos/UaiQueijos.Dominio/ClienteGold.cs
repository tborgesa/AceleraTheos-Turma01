using System;

namespace UaiQueijos.Dominio
{
    public class ClienteGold : Cliente
    {
        public ClienteGold(DateTime dataNascimento, string cpf, string nome)
        : base (dataNascimento, cpf, nome)
        {

        }

        public ClienteGold(DateTime dataNascimento, string cpf, string nome, string endereco)
        : base (dataNascimento, cpf, nome, endereco)
        {

        }

        //override: Sobrescrever o metodo herdado da classe base
        public override double ObterDesconto(double descontoPadrao)
        {
            return descontoPadrao * 2;
        }

        public void EspecificoGold()
        {

        }
    }
}