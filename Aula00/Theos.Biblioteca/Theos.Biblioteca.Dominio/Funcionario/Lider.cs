using PermissaoAlias = Theos.Biblioteca.Dominio.Permissao.Permissao;
using Theos.Biblioteca.Dominio.Setor.Enumerador;

namespace Theos.Biblioteca.Dominio.Funcionario
{
    public class Lider : Funcionario
    {
        public Lider(string nome, string cpf, ESetor setor) : base(nome, cpf, setor)
        {
        }

        public override PermissaoAlias GetPermissao()
        {
            var permissao = base.GetPermissao();
            permissao.PodeEmprestar();
            return permissao;
        }

    }
}
