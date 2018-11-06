using System;

namespace BibliotecaTheos.Dominio.Autores.Autor
{
    class Autor
    {
        public string Nome { get; private set; }

        public Autor(string nome)
        {
            Nome = nome;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }
    }
}
