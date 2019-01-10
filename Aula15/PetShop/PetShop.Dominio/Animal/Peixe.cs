using System;


namespace PetShop.Dominio.Animal
{
    public  class Peixe : Animal
    {
        public decimal Altura;
        public decimal Largura;
        public decimal Comprimento;

        public Peixe(string nome, decimal altura , decimal largura , decimal comprimento):base(nome)
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
