using System;


namespace PetShop.Dominio.Animal
{
    public class Cachorro : Animal
    {
        public Cachorro(double peso, double altura = 0, double largura = 0, double comprimento = 0):base (peso)
        {

        }

        public override void Gravar()
        {
            throw new NotImplementedException();
        }

        public override double ServicoLimpeza(double peso)
        {
            return peso * 2;
        }
    }
}
