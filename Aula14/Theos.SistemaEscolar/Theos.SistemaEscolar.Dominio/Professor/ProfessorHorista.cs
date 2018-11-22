
namespace Theos.SistemaEscolar.Dominio.Professor
{
    public class ProfessorHorista : Professor
    {
        decimal salarioFinal = 0;

        public int HorasTrabalhadas { get; private set; }
        public ProfessorHorista(string nome, decimal salario, string cpf)
            : base(nome, salario, cpf)
        {

        }

     
        public override decimal CalcularSalario()
        {
            salarioFinal = HorasTrabalhadas * 17;
            return salarioFinal;
        }
    }
}
