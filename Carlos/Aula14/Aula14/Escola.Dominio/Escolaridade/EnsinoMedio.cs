using System;

namespace Escola.Dominio
{
    public class EnsinoMedio : Contratado
    {
		public EnsinoMedio(double valorSalario)
			: base(valorSalario)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 1000;
		}
	}
}
