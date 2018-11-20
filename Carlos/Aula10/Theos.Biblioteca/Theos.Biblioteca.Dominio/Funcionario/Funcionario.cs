using Theos.Biblioteca.Comum;
using SetorAlias = Theos.Biblioteca.Dominio.Setor.Setor;
using Theos.Biblioteca.Dominio.Setor.Enumerador;


namespace Theos.Biblioteca.Dominio
{
    public class Funcionario
    {
        public Funcionario(string nome, string cpf, ESetor setor)
        {
            Nome = nome;
            Cpf = cpf;
            InstanciarSetor(setor);


            {
                switch (setor)
                {
                    case ESetor.Desenvolvimento:
                        Setor = new Desenvolvimento();
                        break;
                    case ESetor.Suporte:
                        Setor = new Suporte();
                        break;
                    case ESetor.Teste:
                        Setor = new Teste();
                        break;

                    default:
                        break;
                }
            }
        }

        public string Nome { get; }
        public string Cpf { get; }
        public SetorAlias Setor { get; private set; }
    }
}
