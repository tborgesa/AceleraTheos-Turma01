using System;

namespace Theos.Biblioteca.Dominio
{
    public class Permissao
    {
        public bool CadastrarLivro { get; }
        public bool AlterarLivro { get; }
        public bool EmprestarLivro { get; }
        public bool DevolverLivro { get; }
    }
}
