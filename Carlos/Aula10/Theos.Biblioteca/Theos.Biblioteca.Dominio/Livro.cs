using System;
using Theos.Biblioteca.Comum;

namespace Theos.Biblioteca.Dominio
{
    public class Livro
    {
        public Livro(string nome, string assunto, string editora, string autor)
        {
            Nome = nome;
            Assunto = assunto;
            Editora = editora;
            Autor = autor;
        }

        public string Nome { get; private set; }
        public string Assunto { get; private set; }
        public string Editora { get; private set; }
        public string Autor { get; private set; }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarAssunto(string assunto)
        {
            Assunto = assunto;
        }

        public void AlterarEditora(string editora)
        {
            Editora = editora;
        }

        public void AlterarAutor(string autor)
        {
            Autor = autor;
        }
    }
}
