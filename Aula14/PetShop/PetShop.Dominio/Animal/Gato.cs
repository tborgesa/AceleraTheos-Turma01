using System;


namespace PetShop.Dominio.Animal
{
    public class Gato : Animal
    {
        public Gato(double peso, double altura = 0, double largura = 0, double comprimento = 0) : base(peso)
        {

        }

        public override void Gravar()
        {
            throw new NotImplementedException();
        }

        public override double ServicoLimpeza(double peso)
        {
            return peso * 1.6;
        }
    }
}
