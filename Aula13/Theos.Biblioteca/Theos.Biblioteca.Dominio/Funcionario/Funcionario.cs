using Theos.Biblioteca.Dominio.Setor;
using Theos.Biblioteca.Dominio.Setor.Enumerador;
using SetorAlias = Theos.Biblioteca.Dominio.Setor.Setor;
using PermissaoAlias = Theos.Biblioteca.Dominio.Permissao.Permissao;
using System;

namespace Theos.Biblioteca.Dominio.Funcionario
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
                case ESetor.Teste:
                    Setor = new Teste();
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
        public SetorAlias Setor { get; private set; }

        public virtual PermissaoAlias GetPermissao()
        {
            PermissaoAlias permissao = Setor.GetPermissao();
            return permissao;
        }
    }
}
