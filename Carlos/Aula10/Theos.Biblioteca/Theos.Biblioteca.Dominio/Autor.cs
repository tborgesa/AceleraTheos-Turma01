using System;
using Theos.Biblioteca.Comum;

namespace Theos.Biblioteca.Dominio
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
