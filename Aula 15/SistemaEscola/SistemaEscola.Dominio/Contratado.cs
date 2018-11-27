using SistemaEscola.Dominio.Escolaridade.Enumerador;
using EscolaridadeALias = SistemaEscola.Dominio.Escolaridade.Escolaridade;
using EscolaridadeALiasAux = SistemaEscola.Dominio.Escolaridade;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Contratado : Funcionario
    {
        public EscolaridadeALias Escolaridade { get; private set; }
        public string erro = "Escolaridade Invalida!";

        public Contratado(string nome, EEscolaridade escolaridade) : base (nome)
        {
            InstanciarEscolaridade(escolaridade);
        }

        private void InstanciarEscolaridade(EEscolaridade eEscolaridade)
        {
            if (!EEscolaridade.IsDefined(typeof(EEscolaridade), eEscolaridade))
            {
                System.Console.WriteLine(erro);
                return;
            }

            switch (eEscolaridade)
            {
                case EEscolaridade.SegudundoGrau:
                    Escolaridade = new EscolaridadeALiasAux.SegundoGrau();
                    break;
                case EEscolaridade.EnsinoSuperior:
                    Escolaridade = new EscolaridadeALiasAux.EnsinoSuperior();
                    break;
                case EEscolaridade.Mestrado:
                    Escolaridade = new EscolaridadeALiasAux.Mestrado();
                    break;
                case EEscolaridade.Doutorado:
                    Escolaridade = new EscolaridadeALiasAux.Doutorado();
                    break;
                default:
                    break;
            }
        }

        public override void Gravar()
        {

        }

        public override decimal SalarioFuncionario()
        {
            return Escolaridade.Salario;
        }
    }
}
