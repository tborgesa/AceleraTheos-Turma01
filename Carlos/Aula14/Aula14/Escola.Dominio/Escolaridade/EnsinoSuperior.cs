using System;

namespace Escola.Dominio
{
    public class EnsinoSuperior : Contratado
    {
		public EnsinoSuperior(double valorSalario)
			: base(valorSalario)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 1800;
		}
	}
}
