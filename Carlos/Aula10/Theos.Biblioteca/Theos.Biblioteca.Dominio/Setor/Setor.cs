namespace Theos.Biblioteca.Dominio.Setor
{
    public class Setor
    {
        public Setor(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }

        public virtual Permissao GetPermissao()
        {
            Permissao permissao = new Permissao();
            permissao.PermissaoDevolver();
            return permissao;
        }
    }
}
