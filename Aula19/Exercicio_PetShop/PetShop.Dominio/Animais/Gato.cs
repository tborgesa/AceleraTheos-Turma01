using PetShop.Dominio.Pessoas;
using PetShop.Dominio.Animais.Enumerador;
using System;

namespace PetShop.Dominio.Animais
{
    public class Gato : Animal
    {
        
        public string Raca { get; }
        public double Peso { get; private set; }

        public Gato(string nome, Cliente dono,  double peso)
            : base (nome, dono)
        {
            Peso = peso;
        }

        public override double CalcularLimpeza()
        {
            ValorLimpeza = Peso * 1.6;
            return ValorLimpeza;
        }

        
    }
}
