using System;


namespace Theos.Biblioteca.Domininio.Funcionario
{
   public class Funcionario
    {
        public Funcionario(string nome, string cpf, string setor)
        {
            Nome = nome;
            Cpf = cpf;
            Setor = setor;
        }

        private string Nome { get; }
        private string Cpf { get; }
        private string Setor { get; }
    }
}
