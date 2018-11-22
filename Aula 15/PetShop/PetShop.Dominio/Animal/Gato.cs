using System;


namespace PetShop.Dominio.Animal
{
    public class Gato : AnimalTerrestre
    {
        public Gato(string nome, decimal peso) : base(nome, peso)
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
