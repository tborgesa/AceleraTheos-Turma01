using SistemaEscola.Dominio.Funcionario;

namespace SistemaEscola.Dominio.Funcionario
{
    public class Horaista : Funcionario
    {
        public double Horas;

        public Horaista(string nome, decimal salario, double horas):base(nome, salario)
        {
            Horas = horas;
        }

        public override void Gravar()
        {
        }

        public override decimal SalarioFuncionario()
        {
            return (decimal)Horas * Salario;
        }
    }
}
