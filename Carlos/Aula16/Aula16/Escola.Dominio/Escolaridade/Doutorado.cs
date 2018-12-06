using System;

namespace Escola.Dominio
{
    public class Doutorado : Contratado
    {
		public Doutorado(int codigo, string nome, double valorSalario)
			: base(codigo, nome, valorSalario)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 5000;
		}
	}
}
