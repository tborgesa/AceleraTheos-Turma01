using PetShop.Dominio.Pessoas;
using System;

namespace PetShop.Dominio.Animais
{
    public class Gato : Animal
    {
        
        public string Raca { get; }
        public double Peso { get; private set; }

        public Gato(string nome, Cliente dono, string raca, double peso)
            : base(nome, dono)
        {
            Raca = raca;
            Peso = Peso;
        }

        public double CalcularLimpeza(double peso, double multiplicador)
        {
            return peso * multiplicador;
        }
    }
}
