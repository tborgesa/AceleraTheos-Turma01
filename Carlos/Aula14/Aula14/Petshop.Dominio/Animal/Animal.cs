using System;

namespace Petshop.Dominio
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public double Peso { get; set; }

        public Animal(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }

        public abstract double CalcularValorServico();

    }
}

