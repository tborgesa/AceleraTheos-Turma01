using PetShop.Dominio.Pessoas;
using PetShop.Dominio.Animais.Enumerador;
using System;

namespace PetShop.Dominio.Animais
{
    public class Peixe : Animal
    {
        public double Altura { get; private set; }
        public double Largura { get; private set; }
        public double Comprimento { get; private set; }


        public Peixe(string nome, Cliente dono, EnumEspecie especie, double altura, double largura, double comprimento)
            : base (nome, dono, especie)
        {
            Altura = altura;
            Largura = largura;
            Comprimento = comprimento;
        }

        public override double CalcularLimpeza()
        {
            ValorLimpeza = (Altura * Largura * Comprimento) * 1.5;
            return ValorLimpeza;
        }

    }
}
