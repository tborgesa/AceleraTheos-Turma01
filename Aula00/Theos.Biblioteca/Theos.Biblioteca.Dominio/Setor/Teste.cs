using PermissaoAlias = Theos.Biblioteca.Dominio.Permissao.Permissao;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Teste : Setor
    {
        public Teste()
            : base("Teste")
        {

        }

        public override PermissaoAlias GetPermissao()
        {
            PermissaoAlias permissao = base.GetPermissao();
            permissao.PodeExcluir();
            return permissao;
        }
    }
}
