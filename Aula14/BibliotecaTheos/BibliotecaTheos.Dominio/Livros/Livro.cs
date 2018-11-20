using System;
using BibliotecaTheos.Dominio.Editoras.Editora;
using BibliotecaTheos.Dominio.Autores.Autor;

namespace BibliotecaTheos.Dominio.Livro
{
    class Livro
    {
        private string Titulo { get; }
        private string Assunto { get; }
        private Editora Editora { get; }
        private Autor Autor { get; }

        public Livro(string titulo, string assunto, string , Editora editora, Autor autor )
        {
            Titulo = titulo;
            Assunto = assunto;
            Editora = editora;
            Autor = autor;
        }
    }
}
