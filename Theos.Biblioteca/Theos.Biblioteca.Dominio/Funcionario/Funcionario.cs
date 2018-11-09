using Theos.Biblioteca.Dominio.Setor;
using Theos.Biblioteca.Dominio.Setor.Enumerador;
using SetorAlias = Theos.Biblioteca.Dominio.Setor.Setor;

namespace Theos.Biblioteca.Dominio.Funcionario
{
   public class Funcionario
    {
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
                    Setor = new Desenvolvimento();
                    break;
                case ESetor.Comercial:
                    Setor = new Comercial();
                    break;
                case ESetor.Contabilidade:
                    Setor = new Contabilidade();
                    break;
                case ESetor.Desenvolvimento:
                    Setor = new Desenvolvimento();
                    break;
                case ESetor.Financeiro:
                    Setor = new Financeiro();
                    break;
                case ESetor.Implantacao:
                    Setor = new Implantacao();
                    break;
                case ESetor.Qualidade:
                    Setor = new Qualidade();
                    break;
                case ESetor.Suporte:
                    Setor = new Suporte();
                    break;
                default:
                    break;
            }
        }

        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public SetorAlias Setor { get; private set; }
    }
}
