
namespace Theos.PetShop.Dominio.Animais
{
    public class Peixe : Animal
    {
        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Comprimento { get; private set; }
        double resultado = 0.0;

        public Peixe(string nome, double altura, double largura, double comprimento)
            : base(nome)
        {
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
        }

        public override double CalculaLimpeza()
        {
            resultado = (Altura * Largura * Comprimento) * 1.5;
            return resultado;
        }
    }
}
