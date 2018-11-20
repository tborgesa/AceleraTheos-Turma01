using System;


namespace PetShop.Dominio.Animal
{
    public  class Peixe : Animal
    {
        public Peixe(double peso, double altura , double largura , double comprimento) : base (peso = 0)
        {
            Altura = altura;
            Comprimento = comprimento;
            Largura = largura;
        }

        public override void Gravar()
        {
            throw new NotImplementedException();
        }

        public override double ServicoLimpeza(double peso)
        {
            return peso * 1.6;
        }
    }
}
