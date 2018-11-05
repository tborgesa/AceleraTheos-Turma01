using System;


namespace Theos.Biblioteca.Dominio.Funcionario
{
   public class Funcionario
    {
        public Funcionario(string nome, string cpf, string setor)
        {
            Nome = nome;
            Cpf = cpf;
            Setor = setor;
        }

        public string Nome { get; }
        public string Cpf { get; }
        public string Setor { get; }
    }
}
