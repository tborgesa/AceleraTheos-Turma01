using PetShop.Dominio.Pessoas;
using System;

namespace PetShop.Dominio.Animais
{
    public class Cachorro : Animal
    {
        public string Raca { get; }
        public double Peso { get; private set; }

        public Cachorro(string nome, Cliente dono, string raca, double peso)
            : base (nome, dono)
        {
            Raca = raca;
            Peso = peso;
        }

        public double CalcularLimpeza(double peso, double multiplicador)
        {
            return peso * multiplicador;
        }
    }
}
