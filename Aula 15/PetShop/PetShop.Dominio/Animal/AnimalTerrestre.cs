using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio.Animal
{
    public abstract class AnimalTerrestre : Animal
    {
        protected AnimalTerrestre(string nome, decimal peso): base (nome)
        {
            this.Peso = peso;
        }

        public decimal Peso { get; }
    }
}
