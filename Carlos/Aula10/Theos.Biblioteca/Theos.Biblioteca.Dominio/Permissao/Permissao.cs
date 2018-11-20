using System;

namespace Theos.Biblioteca.Dominio
{
    public class Permissao
    {
        public bool CadastrarLivro { get; private set; }
        public bool ExcluirLivro { get; private set; }
        public bool AlterarLivro { get; private set; }
        public bool EmprestarLivro { get; private set; }
        public bool DevolverLivro { get; private set; }

        // Quando o metodo tiver somente uma linha pode fazer assim:
        // public void PermissaoCadastrar() => PermissaoCadastrar = true;

        public void PermissaoCadastrar()
        {
            CadastrarLivro = true;
        }

        public void PermissaoExcluir()
        {
            ExcluirLivro = true;
        }

        public void PermissaoAlterar()
        {
            AlterarLivro = true;
        }

        public void PermissaoEmprestar()
        {
            EmprestarLivro = true;
        }

        public void PermissaoDevolver()
        {
            DevolverLivro = true;
        }
    }
}
