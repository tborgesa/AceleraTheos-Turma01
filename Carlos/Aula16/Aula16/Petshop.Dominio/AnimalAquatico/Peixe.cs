using System;

namespace Petshop.Dominio
{
	public class Peixe : AnimalAquatico
	{
		public Peixe(double altura, double largura, double comprimento)
			: base(altura, largura, comprimento)
		{

		}

		public override double CalcularValorServico()
		{
			return ((Largura * Altura * Comprimento) / 1000) * 1.5;
		}
	}
}
