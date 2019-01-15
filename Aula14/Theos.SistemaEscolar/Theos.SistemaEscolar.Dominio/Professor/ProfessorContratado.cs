using Theos.SistemaEscolar.Comum;
using Theos.SistemaEscolar.Dominio.Enumerador;

namespace Theos.SistemaEscolar.Dominio.Professor
{
    public class ProfessorContratado : Professor
    {
        public EEscolaridade Escolaridade { get; private set; }

        public ProfessorContratado()
        {

        }

        public ProfessorContratado(string nome, string cpf, EEscolaridade escolaridade)
             : base(nome, cpf)
        {
            Escolaridade = escolaridade;
        }


        public override decimal CalcularSalario()
        {
       
            switch (Escolaridade)
            {
                case EEscolaridade.SegundoGrau:
                    return 1000;
                case EEscolaridade.EnsinoSuperior:
                    return 1800;  
                case EEscolaridade.Mestrado:
                    return 3000;
                case EEscolaridade.Doutorado:
                    return 5000;
                default:
                    return 0;
            }
        }
    }
}
