using System;

namespace Theos.Biblioteca.Domininio.Autor
{
    public class Autor
    {
        public Autor(string nome)
        {
            Nome = nome;
        }

        private string Nome { get; }
    }
}
