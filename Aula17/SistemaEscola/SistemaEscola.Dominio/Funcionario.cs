namespace SistemaEscola.Dominio.Funcionario
{
    public abstract class Funcionario
    {
        public string Nome { get; }
        public string Cpf { get; }

        protected Funcionario(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;

        }

        public abstract  decimal SalarioFuncionario();

        public abstract void Gravar();

    }
}
