using System;


namespace PetShop.Dominio.Animal.Peixe
{
    public class Peixe : Animal
    {
        public Peixe(string nomeAnimal, string nomeDono, string cpfDono, decimal altura, decimal largura, decimal comprimento) :
            base(nomeAnimal, nomeDono, cpfDono)
        {
            Altura = altura;
            Comprimento = comprimento;
            Largura = largura;
        }

        public decimal Altura { get; private set; }
        public decimal Comprimento { get; private set; }
        public decimal Largura { get; private set; }

        public void AlterarDimensao(decimal altura, decimal comprimento, decimal largura)
        {
            Altura = altura;
            Comprimento = comprimento;
            Largura = largura;
        }
        
        public override void Gravar()
        {
        }

        public override decimal ServicoLimpeza()
        {
            return (Altura * Largura * Comprimento) * (decimal)1.6;
        }
    }
}
