using Theos.Biblioteca.Dominio.Setor.Enumerador;
using PermissaoAlias = Theos.Biblioteca.Dominio.Permissao;

namespace Theos.Biblioteca.Dominio.Funcionario
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf, ESetor setor)
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
