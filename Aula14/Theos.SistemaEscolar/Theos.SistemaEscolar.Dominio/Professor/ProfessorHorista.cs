
namespace Theos.SistemaEscolar.Dominio.Professor
{
    public class ProfessorHorista : Professor
    {
        decimal salarioFinal = 0;

        public int HorasTrabalhadas { get; private set; }
        public ProfessorHorista(string nome, string cpf, int horasTrabalhadas)
            : base(nome, cpf)
        {
            HorasTrabalhadas = horasTrabalhadas;
        }


        public override decimal CalcularSalario()
        {
            salarioFinal = HorasTrabalhadas * 17;
            return salarioFinal;
        }

        public void Alterar(string nome, string cpf, int horasTrabalhadas)
        {
            HorasTrabalhadas = horasTrabalhadas;
            base.Alterar(nome, cpf);
        }

    }
}
