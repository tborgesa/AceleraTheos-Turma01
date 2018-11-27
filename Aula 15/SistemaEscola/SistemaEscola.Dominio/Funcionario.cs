namespace SistemaEscola.Dominio.Funcionario
{
    public abstract class Funcionario
    {
        public string Nome { get; }

        protected Funcionario(string nome)
        {
            Nome = nome;

        }

        public abstract  decimal SalarioFuncionario();

        public abstract void Gravar();

    }
}
