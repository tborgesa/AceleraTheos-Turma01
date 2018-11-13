using PermissaoAlias = Theos.Biblioteca.Dominio.Permissao;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Setor
    {
        public Setor(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; }

        public virtual PermissaoAlias GetPermissao()
        {
            var permissao = new PermissaoAlias();

            permissao.PodeDevolver();

            return permissao;
        }
    }
}
