using System;

namespace Escola.Dominio
{
    public class Mestrado : Contratado
    {
		public Mestrado(double valorSalario, int codigo, string nome)
			: base(valorSalario, codigo, nome)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 3000;
		}
	}
}
