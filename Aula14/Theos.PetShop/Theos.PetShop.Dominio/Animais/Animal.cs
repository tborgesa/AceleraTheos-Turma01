using System;
using Theos.PetShop.Comum.Helpers;
using Theos.PetShop.Dominio.Enumerador;

namespace Theos.PetShop.Dominio.Animais
{
    public abstract class Animal
    {
        public string Nome { get; private set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
        public abstract double CalculaLimpeza();
    }
}
