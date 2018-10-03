namespace ProvaInicial.Calculadora
{
    public class Operacao
    {
        public Operacao(double fator1, double fator2)
        {
            Fator1 = fator1;
            Fator2 = fator2;
        }

        public double Fator1 { get; private set; }
        public double Fator2 { get; private set; }

        public double Soma()
        {
            return Fator1 + Fator2;
        }
    }
}
