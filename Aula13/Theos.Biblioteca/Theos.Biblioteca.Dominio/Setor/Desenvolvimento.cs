using PermissaoAlias = Theos.Biblioteca.Dominio.Permissao.Permissao;

namespace Theos.Biblioteca.Dominio.Setor
{
    public class Desenvolvimento : Setor
    {
        public Desenvolvimento()
            :base("Desenvolvimento")
        {

        }

        public override PermissaoAlias GetPermissao()
        {
            PermissaoAlias permissao = base.GetPermissao();
            permissao.PodeAlterar();
            return permissao;
        }
    }
}
