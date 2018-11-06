using System;

namespace UaiQueijos.Dominio
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

        // virtual : todo mundo que herda pode alterar
        public virtual double ObterDesconto(double descontoPadrao)
        {
            return descontoPadrao;
        }
    }
}