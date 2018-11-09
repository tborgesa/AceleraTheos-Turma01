using System;
using BibliotecaTheos.Dominio.Setores;
using BibliotecaTheos.Dominio.Permissoes;
using BibliotecaTheos.Dominio.Setores.Enumerador;

namespace BibliotecaTheos.Dominio.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public string Cpf { get; }
        public Setor Setor { get; private set; }

        public Funcionario(string nome, string cpf, ESetor setor)
        {
            Nome = nome;
            Cpf = cpf;
        }

        private void InstanciarSetor(ESetor setor)
        {
            switch (setor)
            {
                case ESetor.Administrativo:
                    Setor = new Administrativo();
                    break;
                case ESetor.Contabil:
                    Setor = new Contabil();
                    break;
                case ESetor.Dba:
                    Setor = new Dba();
                    break;
                case ESetor.Desenvolvimento:
                    Setor = new Desenvolvimento();
                    break;
                case ESetor.Implantacao:
                    Setor = new Implantacao();
                    break;
                case ESetor.Marketing:
                    Setor = new Marketing();
                    break;
                case ESetor.QA:
                    Setor = new QA();
                    break;
                case ESetor.Suporte:
                    Setor = new Suporte();
                    break;
                default:
                    break;
            }
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarSetor(Setor setor)
        {
            Setor = setor;
        }

        public virtual Permissao GetPermissao()
        {
            Permissao permissao = new Permissao();
            permissao.PodeDevolver();
            return permissao;
        }

    }
}
