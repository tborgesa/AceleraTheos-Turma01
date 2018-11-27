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
            switch (setor)
            {
                case ESetor.Administrativo:
                    Setor = new Setor.Administrativo();
                    break;
                case ESetor.Contabil:
                    Setor = new Setor.Contabil();
                    break;
                case ESetor.Desenvolvimento:
                    Setor = new Setor.Desenvolvimento();
                    break;
                case ESetor.Implantacao:
                    Setor = new Setor.Implantacao();
                    break;
                case ESetor.Suporte:
                    Setor = new Setor.Suporte();
                    break;
                case ESetor.teste:
                    Setor = new Setor.Teste();
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
