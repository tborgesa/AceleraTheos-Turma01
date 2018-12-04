using System;

namespace Escola.Dominio
{
    public class EnsinoMedio : Contratado
    {
		public EnsinoMedio(double valorSalario, int codigo, string nome)
			: base(valorSalario, codigo, nome)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 1000;
		}
	}
}
