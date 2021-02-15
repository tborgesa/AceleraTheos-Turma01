using System;
namespace BibliotecaTheos.Dominio.Funcionarios.Funcionario
{
    class Funcionario
    {
        public string Nome { get; private set; }
        public string Cpf { get; }
        public string Setor { get; set; }

        public Funcionario(string nome, string cpf, string setor)
        {
            Nome = nome;
            Cpf = cpf;
            Setor = setor;
        }
    }
}
