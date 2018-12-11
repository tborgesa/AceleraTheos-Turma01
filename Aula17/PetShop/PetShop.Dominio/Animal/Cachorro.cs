using System;


namespace PetShop.Dominio.Animal
{
    public class Cachorro : AnimalTerrestre
    {
        public Cachorro(string nomeAnimal, string nomeDono, string cpfDono, decimal peso) : base(nomeAnimal, nomeDono, cpfDono,peso)
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
