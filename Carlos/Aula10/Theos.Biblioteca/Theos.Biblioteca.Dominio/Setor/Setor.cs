using System;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Setor
    {
        public Setor(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }
    }
}
