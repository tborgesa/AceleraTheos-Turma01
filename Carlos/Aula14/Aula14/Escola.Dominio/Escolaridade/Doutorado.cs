using System;

namespace Escola.Dominio
{
    public class Doutorado : Contratado
    {
		public Doutorado(double valorSalario)
			: base(valorSalario)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 5000;
		}
	}
}
