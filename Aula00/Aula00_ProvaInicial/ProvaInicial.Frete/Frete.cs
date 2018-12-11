namespace ProvaInicial.Frete
{
    public class Frete
    {
        public int CalcularFrete(double altura, double largura, double comprimento, double peso)
        {
            double valorBase = peso;

            if (peso > 1)
                valorBase = 1 / peso;

            double valorFrete = (altura + largura + comprimento) / valorBase;
            return (int) valorFrete;
        }

    }
}
