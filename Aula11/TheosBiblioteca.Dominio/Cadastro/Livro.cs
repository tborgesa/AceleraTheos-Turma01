using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheosBiblioteca.Dominio.Cadastro.Livro
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

        public string Nome { get; }
        public string Assunto { get; }
        public string Editora { get; }
        public string Autor { get; }
    }
}