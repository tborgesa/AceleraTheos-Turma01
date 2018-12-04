using System;

namespace Petshop.Dominio
{
	public class Cachorro : AnimalTerrestre
	{
		public Cachorro(string nome, double peso)
			: base(nome, peso)
		{

		}

		public override double CalcularValorServico()
		{
			return Peso * 2;
		}
	}
}
