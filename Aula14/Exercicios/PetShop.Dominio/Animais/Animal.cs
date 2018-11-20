using PetShop.Dominio.Pessoas;
using System;

namespace PetShop.Dominio.Animais
{
    public class Animal
    {
        public string Nome { get; }
        public DateTime  DataNascimento { get; }
        public Cliente Dono { get; private set; }
        public string Especie { get; }
        public string erro { get; private set; }

        public Animal(string especie)
        {
            Especie = especie;
        }

        public Animal(string nome, Cliente dono)
        {
            Nome = nome;
            Dono = dono;
        }

        public void AlterarDono(Cliente dono)
        {
            Dono = dono;
        }
    }
}
