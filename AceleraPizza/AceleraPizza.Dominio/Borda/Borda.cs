namespace AceleraPizza.Dominio.Borda
{
    public abstract class Borda
    {
        protected Borda(string bordaDescricao, double valor)
        {
            BordaDescricao = bordaDescricao;
            Valor = valor;
        }

        public virtual double GetBordaValor()
        {
            return Valor;
        }

        public string erro { get; private set; }

        public string BordaDescricao { get; private set; }

        public double Valor { get; }
    }
}