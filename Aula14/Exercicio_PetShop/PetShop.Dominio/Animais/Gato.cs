using PetShop.Dominio.Pessoas;
using PetShop.Dominio.Animais.Enumerador;
using System;

namespace PetShop.Dominio.Animais
{
    public class Gato : Animal
    {
        
        public string Raca { get; }
        public double Peso { get; private set; }

        public Gato(string nome, Cliente dono, EnumEspecie especie, double peso)
            : base (nome, dono, especie)
        {
            Peso = peso;
        }

        public override double CalcularLimpeza()
        {
            return Peso * 1.6;
        }
    }
}
