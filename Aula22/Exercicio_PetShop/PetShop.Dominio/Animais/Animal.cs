﻿using PetShop.Dominio.Animais.Enumerador;
using PetShop.Dominio.Pessoas;
using System;

namespace PetShop.Dominio.Animais
{
    public abstract class Animal : Entidade
    {
        public string Nome { get; }
        public Cliente Cliente { get; private set; } 
        public double ValorLimpeza { get; set; }
        public EnumEspecie Especie { get; set; }

        public Animal(string nome, Cliente cliente, EnumEspecie especie)
        {
            Nome = nome;
            Cliente = cliente;
            Especie = especie;
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
