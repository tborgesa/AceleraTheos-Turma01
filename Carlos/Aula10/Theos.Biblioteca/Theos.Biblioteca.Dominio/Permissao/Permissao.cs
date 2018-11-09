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

        public void PermissaoCadastrarLivro(bool cadastrarLivro)
        {
            CadastrarLivro = cadastrarLivro;
        }

        public void PermissaoExcluirLivro(bool excluirLivro)
        {
            ExcluirLivro = excluirLivro;
        }

        public void PermissaoAlterarLivro(bool alterarLivro)
        {
            AlterarLivro = alterarLivro;
        }

        public void PermissaoEmprestarLivro(bool emprestarLivro)
        {
            EmprestarLivro = emprestarLivro;
        }

        public void PermissaoDevolverLivro(bool devolverLivro)
        {
            DevolverLivro = devolverLivro;
        }
    }
}
