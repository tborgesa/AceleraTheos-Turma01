namespace AceleraPizza.Dominio.Borda
{
    public abstract class Borda
    {
        protected Borda(string ingredientesDescricao, double valor)
        {
            this.erro = erro;
            BordaDescricao = ingredientesDescricao;
            Valor = valor;
        }

        public virtual double GetValorBorda()
        {
            var total = 2;
            return total;
        }

        public string erro { get; private set; }
        public string BordaDescricao { get; private set; }
        public double Valor { get; }
    }
}

