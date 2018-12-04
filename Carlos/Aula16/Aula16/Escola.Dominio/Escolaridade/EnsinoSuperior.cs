using System;

namespace Escola.Dominio
{
    public class EnsinoSuperior : Contratado
    {
		public EnsinoSuperior(double valorSalario, int codigo, string nome)
			: base(valorSalario, codigo, nome)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 1800;
		}
	}
}
