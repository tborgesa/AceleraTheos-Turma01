namespace AceleraPizza.Dominio.Tamanho
{
    public abstract class Tamanho
    {
        protected Tamanho(string tamanhoDescricao, double valor)
        {
            TamanhoDescricao = tamanhoDescricao;
            Valor = valor;
        }

        public virtual double GetBordaValor()
        {
            return Valor;
        }

        public string erro { get; private set; }

        public string TamanhoDescricao { get; private set; }

        public double Valor { get; }
    }
}