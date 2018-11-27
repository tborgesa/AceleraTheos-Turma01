using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theos.Biblioteca.Dominio
{
    class Livro
    {
        public string Nome { get;  }
        public string Assunto { get;  }
        public string Editora { get;  }
        public string Autor { get;  }
        public string Edicao { get;  }

        public Livro(string nome, string assunto, string editora, string autor )
        {
            Nome = nome;
            Assunto = assunto;
            Editora = editora;
            Autor = autor;
        }

        public Livro(string nome, string assunto, string editora, string autor,string edicao)
        {
            Nome = nome;
            Assunto = assunto;
            Editora = editora;
            Autor = autor;
            Edicao = edicao;
        }
    }
}
