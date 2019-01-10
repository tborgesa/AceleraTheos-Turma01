namespace PetShop.Dominio.Animal
{
    public abstract class AnimalTerrestre : Animal
    {
        protected AnimalTerrestre(string nomeAnimal, string nomeDono, string cpfDono, decimal peso)
            : base (nomeAnimal, nomeDono, cpfDono)
        {
            Peso = peso;
        }

        public decimal Peso { get; }
    }
}
