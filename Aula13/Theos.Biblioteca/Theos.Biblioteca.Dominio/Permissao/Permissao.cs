namespace Theos.Biblioteca.Dominio.Permissao
{
    public class Permissao
    {
        public bool CadastrarLivro { get; private set; }
        public bool ExcluirLivro { get; private set; }
        public bool AlterarLivro { get; private set; }
        public bool EmprestarLivro { get; private set; }
        public bool DevolverLivro { get; private set; }
        
        public void PodeCadastrar() => CadastrarLivro = true;
        public void PodeExcluir() => ExcluirLivro = true;
        public void PodeAlterar() => AlterarLivro = true;
        public void PodeEmprestar() => EmprestarLivro = true;
        public void PodeDevolver() => DevolverLivro = true;

        public void PodeTudo()
        {
            PodeCadastrar();
            PodeExcluir();
            PodeAlterar();
            PodeEmprestar();
            PodeDevolver();
        }
    }
}
