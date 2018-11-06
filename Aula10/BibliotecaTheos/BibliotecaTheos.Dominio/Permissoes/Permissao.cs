using System;


namespace BibliotecaTheos.Dominio.Permissoes
{
    public class Permissao
    {
        public bool CadastrarLivro { get; private set; }
        public bool AlterarLivro { get; private set; }
        public bool ExcluirLivro { get; private set; }
        public bool FazerEmprestimo { get; private set; }
        public bool DevolverLivro { get; private set; }

        public Permissao() {}

        public void PodeCadastrarLivro()
        {
            CadastrarLivro = true;
        }

        public void PodeAlterarLivro()
        {
            AlterarLivro = true;
        }

        public void PodeExcluirLivro()
        {
            ExcluirLivro = true;
        }

        public void PodeEmprestarLivro()
        {
            FazerEmprestimo = true;
        }

        public void PodeDevolverLivro()
        {
            DevolverLivro = true;
        }
    }
}
