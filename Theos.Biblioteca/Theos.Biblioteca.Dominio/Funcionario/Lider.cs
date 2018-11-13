using PermissaoAlias = Theos.Biblioteca.Dominio.Permissao;
using Theos.Biblioteca.Dominio.Setor.Enumerador;

namespace Theos.Biblioteca.Dominio.Funcionario
{
    public class Lider : Funcionario
    {

        public Lider(string nome, string cpf, ESetor setor)
            : base(nome, cpf, setor)
        {
            
        }

        public override PermissaoAlias GetPermissao()
        {
            PermissaoAlias permissao = base.GetPermissao();

            permissao.PermissaoTotal();

            return permissao;
        }
    }
}
