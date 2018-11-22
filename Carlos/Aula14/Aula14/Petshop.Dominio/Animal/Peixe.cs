using System;

namespace Petshop.Dominio
{
	public class Peixe : Animal
	{
		public double Altura { get; set; }
		public double Largura { get; set; }
		public double Comprimento { get; set; }

		public Peixe(string nome, double peso, double altura, double largura, double comprimento)
			: base(nome, peso)
		{
			Altura = altura;
			Largura = largura;
			Comprimento = comprimento;
		}

		public override double CalcularValorServico()
		{
			return ((Altura * Largura * Comprimento) / 1000) * 1.5;
		}
	}
}
