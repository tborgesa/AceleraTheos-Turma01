using System;


namespace PetShop.Dominio.Animal
{
    public class Cachorro : AnimalTerrestre
    {
        public Cachorro(string nome, decimal peso) : base(nome,peso)
        {

        }

        public override void Gravar()
        {
        }

        public override decimal ServicoLimpeza()
        {
            return base.Peso * 2;
        }
    }
}
