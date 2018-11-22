using System;

namespace Petshop.Dominio
{
	public class Cachorro : Animal
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
