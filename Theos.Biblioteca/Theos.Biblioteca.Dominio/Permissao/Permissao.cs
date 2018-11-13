namespace Theos.Biblioteca.Dominio
{
    public class Permissao
    {
        public bool CadastrarLivro { get; private set; }
        public bool AlterarLivro { get; private set; }
        public bool ExcluirLivro { get; private set; }
        public bool FazerEmprestimo { get; private set; }
        public bool DevolverLivro { get; private set; }

        public void PodeCadastrar() => CadastrarLivro = true;
     
        public void PodeAlterar() => AlterarLivro = true;
      
        public void PodeExcluir() => ExcluirLivro = true;
        
        public void PodeFazerEmprestimo() => FazerEmprestimo = true;
        
        public void PodeDevolver() => DevolverLivro = true;

        public void PermissaoTotal()
        {
            CadastrarLivro = true;
            AlterarLivro = true;
            ExcluirLivro = true;
            FazerEmprestimo = true;
            DevolverLivro = true;
        }
    }
}
