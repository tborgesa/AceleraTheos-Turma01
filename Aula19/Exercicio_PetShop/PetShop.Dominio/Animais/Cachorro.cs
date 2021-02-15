using PetShop.Dominio.Pessoas;
using PetShop.Dominio.Animais.Enumerador;
using System;

namespace PetShop.Dominio.Animais
{
    public class Cachorro : Animal
    {
        public string Raca { get; }
        public double Peso { get; private set; }

        public double _multiplicador = 2;

        public Cachorro(string nome, Cliente dono, double peso)
            : base(nome, dono)
        {
            Peso = peso;
        }

        public override double CalcularLimpeza()
        {
            ValorLimpeza = Peso * 2;
            return ValorLimpeza;
        }
    }
}
