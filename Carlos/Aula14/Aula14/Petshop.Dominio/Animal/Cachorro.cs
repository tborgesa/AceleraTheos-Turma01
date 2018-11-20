using System;

namespace Petshop.Dominio
{
	public class Cachorro : Animal
	{
		public Cachorro(string nome, double peso)
			: base(nome, peso)
		{

		}

		public override double CalcularValorServico(double valorServico)
		{
			return Peso * 2;
		}
	}
}
