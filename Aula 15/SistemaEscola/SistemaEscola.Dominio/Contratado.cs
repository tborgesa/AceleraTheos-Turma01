namespace SistemaEscola.Dominio.Funcionario
{
    public abstract class Contratado : Funcionario
    {
        public Contratado(string nome, decimal salario) : base (nome,salario)
        {
        }

        public abstract override void Gravar();

        public abstract override decimal SalarioFuncionario();
    }
}
