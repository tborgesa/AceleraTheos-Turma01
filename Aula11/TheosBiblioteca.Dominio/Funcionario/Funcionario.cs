using System;

namespace TheosBiblioteca.Dominio.Funcionario
{
    public class Funcionario
    {
        public Funcionario(string setor, string nome)
        {
            Setor = setor;
            Nome = nome;
        }

        public string Setor { get; }
        public string Nome { get; }
    }
}
