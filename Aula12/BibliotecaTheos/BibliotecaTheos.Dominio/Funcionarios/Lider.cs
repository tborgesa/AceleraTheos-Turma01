using System;
using BibliotecaTheos.Dominio.Permissoes;
using BibliotecaTheos.Dominio.Setores;
using BibliotecaTheos.Dominio.Setores.Enumerador;

namespace BibliotecaTheos.Dominio.Funcionarios
{
    public class Lider : Funcionario

    {
        public Lider(string nome, string cpf, ESetor setor)
            : base(nome, cpf, setor)
        {

        }

        public override Permissao GetPermissao()
        {
            var permissao = base.GetPermissao();
            permissao.PodeEmprestar();
            return permissao;
        }
    }
}
