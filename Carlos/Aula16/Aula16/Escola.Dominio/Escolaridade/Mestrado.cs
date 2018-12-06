using System;

namespace Escola.Dominio
{
    public class Mestrado : Contratado
    {
		public Mestrado(int codigo, string nome, double valorSalario)
			: base(codigo, nome, valorSalario)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 3000;
		}
	}
}
