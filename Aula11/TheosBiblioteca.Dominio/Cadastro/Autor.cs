using System;

namespace TheosBiblioteca.Dominio.Cadastro.Autor
{
    public class Autor
    {
        public Autor(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }
    }
}
