namespace Theos.PetShop.Dominio.Animais
{
    public class Cachorro : AnimalComPeso
    {
     
        double resultado = 0.0;

        public Cachorro(string nome, double peso)
            : base(nome, peso)
        {
         
        }
        public override double CalculaLimpeza()
        {
            resultado = Peso * 2;
            return resultado;
        }
    }
}
