using PetShop.Dominio.Animais.Enumerador;
using PetShop.Dominio.Pessoas;
using System;

namespace PetShop.Dominio.Animais
{
    public abstract class Animal : Entidade
    {
        public string Nome { get; }
        public Cliente Dono { get; private set; } 
        public double ValorLimpeza { get; set; }

        public Animal(string nome, Cliente dono)
        {
            Nome = nome;
            Dono = dono;
            ValidarAnimal();
        }

        public abstract double CalcularLimpeza();

        public void ValidarAnimal()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                AdicionarErro("Preencha o nome do animal.");

        }

    }
}
