using System;

namespace PetShop.Dominio.Animal
{
    public abstract class Animal
    {
        public double Peso;
        public double Altura;
        public double Largura;
        public double Comprimento;

        protected Animal(double peso)
        {
            Peso = peso;
        }

        public virtual double ServicoLimpeza(double valor)
        {
            return valor;
        }

        public abstract void Gravar();
    }
}
