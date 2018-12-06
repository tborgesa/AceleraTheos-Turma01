using System;

namespace Escola.Dominio
{
    public class EnsinoMedio : Contratado
    {
		public EnsinoMedio(int codigo, string nome, double valorSalario)
			: base(codigo, nome, valorSalario)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 1000;
		}
	}
}
