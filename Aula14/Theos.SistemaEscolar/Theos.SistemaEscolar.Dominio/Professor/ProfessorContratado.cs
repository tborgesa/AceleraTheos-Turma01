
namespace Theos.SistemaEscolar.Dominio.Professor
{
    public class ProfessorContratado : Professor
    {

        public ProfessorContratado(string nome, decimal salario, string cpf)
             : base(nome, salario, cpf)
        {

        }

        public override decimal CalcularSalario()
        {
            //todo implementar switch para definição do horário

            return 0;
        }
    }
}
