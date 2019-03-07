using PetShop.Dominio.Pessoas;
using PetShop.Dominio.Animais.Enumerador;
using System;

namespace PetShop.Dominio.Animais
{
    public class Cachorro : Animal
    {
        public string Raca { get; set; }
        public double Peso { get; set; }

        public double _multiplicador = 2;

        public Cachorro()
        {

        }

        public Cachorro(string nome, Cliente cliente, EnumEspecie especie ,double peso)
            : base(nome, cliente, especie)
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
