namespace Theos.PetShop.Dominio.Animais
{
    public class Gato : AnimalComPeso
    {
     
        double resultado = 0.0;
        public Gato(string nome, double peso)
            :base(nome, peso)
        {

        }
        public override double CalculaLimpeza()
        {
            resultado = Peso * 1.6;
            return resultado;
        }
    }
}
