using System;
using BibliotecaTheos.Dominio.Setores;
using BibliotecaTheos.Dominio.Permissoes;
using BibliotecaTheos.Dominio.Setores.Enumerador;

namespace BibliotecaTheos.Dominio.Funcionarios
{
    public class Funcionario
    {
        public string erro { get; private set; }

        public Funcionario(string nome, string cpf, ESetor setor)
        {
            Nome = nome;
            Cpf = cpf;
            InstanciarSetor(setor);
        }

        private void InstanciarSetor(ESetor setor)
        {
            if (!Enum.IsDefined(typeof(ESetor), setor))
            {
                erro = "Setor Invalido!";
                return;
            }


            switch (setor)
            {
                case ESetor.Desenvolvimento:
                    Setor = new Desenvolvimento();
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

        public string Nome { get; }
        public string Cpf { get; }
        public Setor Setor { get; private set; }

        public virtual Permissao GetPermissao()
        {
            Permissao permissao = new Permissao();
            permissao.PodeDevolver();
            return permissao;
        }

    }
}
