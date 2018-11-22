using System;

namespace Petshop.Dominio
{
	public abstract class AnimalAquatico : Animal
	{
		public double Altura { get; set; }
		public double Largura { get; set; }
		public double Comprimento { get; set; }

		public AnimalAquatico(double altura, double largura, double comprimento)
		{
			Altura = altura;
			Largura = largura;
			Comprimento = comprimento;
		}
	}
}
