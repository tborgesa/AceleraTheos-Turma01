
namespace Theos.SistemaEscolar.Dominio.Professor
{
    public abstract class Professor
    {

        public string Nome { get; private set; }
        public decimal Salario { get; private set; }
        public string Cpf { get; private set; }

        public Professor(string nome, decimal salario, string cpf)
        {
            Nome = nome;
            Salario = salario;
            Cpf = cpf;
        }

        public abstract decimal CalcularSalario();

    }
}
