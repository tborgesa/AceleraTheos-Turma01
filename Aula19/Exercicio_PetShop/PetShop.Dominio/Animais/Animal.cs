using PetShop.Dominio.Animais.Enumerador;
using PetShop.Dominio.Pessoas;
using System;

namespace PetShop.Dominio.Animais
{
    public abstract class Animal
    {
        public string Nome { get; }
        public Cliente Dono { get; private set; }
        public Enum Especie { get; }
        public string erro { get; private set; }
        public double ValorLimpeza { get; set; }

        public Animal(string nome, Cliente dono, Enum especie)
        {
            Nome = nome;
            Dono = dono;
            Especie = especie;
        }

        public abstract double CalcularLimpeza();

    }
}
