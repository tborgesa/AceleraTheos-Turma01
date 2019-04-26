namespace AceleraPizza.Dominio.Tamanho
{
    public abstract class Tamanho
    {
        protected Tamanho(string tamanhoDescricao)
        {
            TamanhoDescricao = tamanhoDescricao;
        }

        public string erro { get; private set; }

        public string TamanhoDescricao { get; private set; }
    }
}