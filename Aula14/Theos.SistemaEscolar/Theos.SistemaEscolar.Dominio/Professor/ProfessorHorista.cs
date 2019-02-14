
namespace Theos.SistemaEscolar.Dominio.Professor
{
    public class ProfessorHorista : Professor
    {

        public ProfessorHorista()
        {

        }

        decimal salarioFinal = 0;

        public decimal HorasTrabalhadas { get; set; }
        public ProfessorHorista(string nome, string cpf, decimal horasTrabalhadas)
            : base(nome, cpf)
        {
            HorasTrabalhadas = horasTrabalhadas;
        }


        public override decimal CalcularSalario()
        {
            salarioFinal = HorasTrabalhadas * 17;
            return salarioFinal;
        }

        public void Alterar(string nome, string cpf, decimal horasTrabalhadas)
        {
            HorasTrabalhadas = horasTrabalhadas;
            base.Alterar(nome, cpf);
        }

    }
}
