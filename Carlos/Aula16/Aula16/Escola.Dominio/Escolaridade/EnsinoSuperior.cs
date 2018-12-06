using System;

namespace Escola.Dominio
{
    public class EnsinoSuperior : Contratado
    {
		public EnsinoSuperior(int codigo, string nome, double valorSalario)
			: base(codigo, nome, valorSalario)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 1800;
		}
	}
}
