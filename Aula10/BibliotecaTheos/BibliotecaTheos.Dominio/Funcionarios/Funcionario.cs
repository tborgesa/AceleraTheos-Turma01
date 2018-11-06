using System;
using BibliotecaTheos.Dominio.Setores;
using BibliotecaTheos.Dominio.Permissoes;

namespace BibliotecaTheos.Dominio.Funcionarios.Funcionario
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public string Cpf { get; }
        public Setor Setor { get; private set; }

        public Funcionario(string nome, string cpf, Setor setor)
        {
            Nome = nome;
            Cpf = cpf;
            Setor = setor;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarSetor(Setor setor)
        {
            Setor = setor;
        }

        public Permissao GetPermissao()
        {
            Permissao permissao = new Permissao();
            permissao.PodeDevolverLivro();
            return permissao;
        }
    }
}
