using System;


namespace PetShop.Dominio.Animal
{
    public class Gato : AnimalTerrestre
    {
        public Gato(string nomeAnimal, string nomeDono, string cpfDono, decimal peso) : base(nomeAnimal, nomeDono, cpfDono, peso)
        {

        }

        public override void Gravar()
        {
        }

        public override decimal ServicoLimpeza()
        {
            return Peso * (decimal)1.6;
        }
    }
}
