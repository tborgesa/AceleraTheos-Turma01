namespace SistemaEscola.Dominio.Escolaridade
{
    public abstract class Escolaridade
    {

        public Escolaridade (string escolariadadeDescricao, decimal salario)
        {
            EscolariadadeDescricao = escolariadadeDescricao;
            Salario = salario;
        }

        public virtual decimal GetSalario()
        {
            return Salario;
        }

        public string erro { get; private set; }

        public string EscolariadadeDescricao { get; private set; }

        public decimal Salario { get; }
    }
}
