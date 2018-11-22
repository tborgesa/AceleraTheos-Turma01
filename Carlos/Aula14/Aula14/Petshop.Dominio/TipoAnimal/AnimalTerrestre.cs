using System;

namespace Petshop.Dominio
{
	public abstract class AnimalTerrestre : Animal
	{
		public string Nome { get; set; }
		public double Peso { get; set; }

		public AnimalTerrestre(string nome, double peso)
		{
			Nome = nome;
			Peso = peso;
		}
	}
}
