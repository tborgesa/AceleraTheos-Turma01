namespace AceleraPizza.Dominio.Ingredientes
{
    public class IngredientesItens
    {
        public int QuantidadeAzeitona;
        public int QuantidadeBacon;
        public int QuantidadeCebola;
        public int QuantidadeMilho;
        public int QuantidadeMussarela;
        public int QuantidadeOregano;
        public int QuantidadePalmito;
        public int QuantidadePimentaCalabresa;
        public int QuantidadePresunto;

        public IngredientesItens(int quantidadeAzeitona,
                                 int quantidadeBacon,
                                 int quantidadeCebola,
                                 int quantidadeMilho,
                                 int quantidadeMussarela,
                                 int quantidadeOregano,
                                 int quantidadePalmito,
                                 int quantidadePimentaCalabresa,
                                 int quantidadePresunto)
        {
            QuantidadeAzeitona = quantidadeAzeitona;
            QuantidadeBacon = quantidadeBacon;
            QuantidadeCebola = quantidadeCebola;
            QuantidadeMilho = quantidadeMilho;
            QuantidadeMussarela = quantidadeMussarela;
            QuantidadeOregano = quantidadeOregano;
            QuantidadePalmito = quantidadePalmito;
            QuantidadePimentaCalabresa = quantidadePimentaCalabresa;
            QuantidadePresunto = quantidadePresunto;
        }
    }
}
