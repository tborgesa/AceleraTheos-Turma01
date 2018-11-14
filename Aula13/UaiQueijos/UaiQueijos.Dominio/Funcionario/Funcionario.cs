using System;

namespace UaiQueijos.Dominio.Funcionario
{
    public class Funcionario : Pessoa
    {
        public Funcionario(DateTime dataNascimento, string cpf, string nome) 
            : base(dataNascimento, cpf, nome)
        {
        }

        public Funcionario(DateTime dataNascimento, string cpf, string nome, string endereco) 
            : base(dataNascimento, cpf, nome, endereco)
        {
        }

        public override string CriarEmail() => "Funcionario: Feliz Natal e descanse bastante para voltar no gás.";

    }
}
