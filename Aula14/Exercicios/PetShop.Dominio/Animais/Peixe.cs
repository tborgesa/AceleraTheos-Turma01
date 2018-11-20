using PetShop.Dominio.Pessoas;
using System;

namespace PetShop.Dominio.Animais
{
    public class Peixe : Animal
    {
        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Comprimento { get; private set; }

        public Peixe()
            :base("Peixe")
        {
        }

        public double CalcularLimpeza(double altura, double largura, double comprimento)
        {
            return (altura * largura * comprimento) * 1.5;
        }

    }
}
