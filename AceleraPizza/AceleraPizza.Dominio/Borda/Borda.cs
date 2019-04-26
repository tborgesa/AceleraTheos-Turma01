namespace AceleraPizza.Dominio.Borda
{
    public abstract class Borda
    {
        protected Borda(string bordaDescricao)
        {
            BordaDescricao = bordaDescricao;
        }

        public string erro { get; private set; }

        public string BordaDescricao { get; private set; }
    }
}