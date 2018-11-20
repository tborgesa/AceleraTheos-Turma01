using System;
using Theos.PetShop.Comum.Helpers;
using Theos.PetShop.Dominio.Enumerador;

namespace Theos.PetShop.Dominio.Animais
{
    public abstract class Animal
    {
        public Animal(string nome)
        {

        }
        public abstract double CalculaLimpeza();
    }
}
