using Theos.SistemaEscolar.Comum;
using Theos.SistemaEscolar.Dominio.Enumerador;

namespace Theos.SistemaEscolar.Dominio.Professor
{
    public class ProfessorContratado : Professor
    {
        public ProfessorContratado()
        {

        }

        public ProfessorContratado(string nome, string cpf)
             : base(nome, cpf)
        {

        }


        public override decimal CalcularSalario()
        {
            EEscolaridade opcao = (EEscolaridade)InputHelper.GetInputInt(@"Escolha a escolaridade do professor contratado: 
Segundo Grau = 1,
Ensino Superior = 2,
Mestrado = 3,
Doutorado = 4 ", "Entrada inválida");

            switch (opcao)
            {
                case EEscolaridade.SegundoGrau:
                    InputHelper.MensagemUsuario("Salário de R$ 1.000,00 para professor do Segundo Grau");
                    break;
                case EEscolaridade.EnsinoSuperior:
                    InputHelper.MensagemUsuario("Salário de R$ 1.800,00 para professor do Ensino Superior");
                    break;
                case EEscolaridade.Mestrado:
                    InputHelper.MensagemUsuario("Salário de R$ 3.000,00 para professor do Mestrado");
                    break;
                case EEscolaridade.Doutorado:
                    InputHelper.MensagemUsuario("Salário de R$ 5.000,00 para professor do Doutorado");
                    break;
                default:
                    InputHelper.MensagemUsuario("Escolaridade incorreta. Tente novamente");
                    break;

            }
            return 0;
        }
    }
}
