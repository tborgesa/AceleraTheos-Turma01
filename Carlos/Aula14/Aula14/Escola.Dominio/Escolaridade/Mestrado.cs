using System;

namespace Escola.Dominio
{
    public class Mestrado : Contratado
    {
		public Mestrado(double valorSalario)
			: base(valorSalario)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 3000;
		}
	}
}
