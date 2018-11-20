namespace Theos.PetShop.Dominio.Animais
{
    public class Gato : Animal
    {
        public double Peso { get; private set; }
        public string Nome { get; private set; }
        double resultado = 0.0;
        public Gato(string nome, double peso)
            :base(nome)
        {
            Peso = peso;
            Nome = nome;
        }
        public override double CalculaLimpeza()
        {
            resultado = Peso * 2;
            return resultado;
        }
    }
}
