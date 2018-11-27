using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Dominio.Animais
{
    public abstract class AnimalTerrestre : Animal
    {
        public double Peso { get; private set; }

        public AnimalTerrestre(string nome, double peso) : base(nome)
        {
            Peso = peso;
        }

    }
}
