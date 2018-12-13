using System;

namespace UaiQueijos.Dominio.Funcionario
{
    public class Funcionario : Pessoa
    {
        public string NumeroCarteiraTrabalho { get; set; }


        public Funcionario(DateTime dataNascimento, string cpf, string nome, string numeroCarteiraTrabalho) 
            : base(dataNascimento, cpf, nome)
        {
            NumeroCarteiraTrabalho = numeroCarteiraTrabalho;
        }

        public Funcionario(DateTime dataNascimento, string cpf, string nome, string endereco, string numeroCarteiraTrabalho) 
            : base(dataNascimento, cpf, nome, endereco)
        {
            NumeroCarteiraTrabalho = numeroCarteiraTrabalho;
        }

        public override string CriarEmail() => $"Funcionario {NumeroCarteiraTrabalho}: Feliz Natal e descanse bastante para voltar no gás.";
    }
}
