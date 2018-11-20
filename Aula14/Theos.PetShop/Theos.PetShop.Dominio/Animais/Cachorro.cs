namespace Theos.PetShop.Dominio.Animais
{
    public class Cachorro : Animal
    {
        public double Peso { get; private set; }
        public string Nome { get; private set; }
        double resultado = 0.0;

        public Cachorro(string nome, double peso)
            : base(nome)
        {
            Peso = peso;
            Nome = nome;
        }
        public override double CalculaLimpeza()
        {
            resultado = Peso * 1.6;
            return resultado;
        }
    }
}
