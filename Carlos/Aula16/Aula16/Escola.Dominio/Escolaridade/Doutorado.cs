using System;

namespace Escola.Dominio
{
    public class Doutorado : Contratado
    {
		public Doutorado(double valorSalario, int codigo, string nome)
			: base(valorSalario, codigo, nome)
		{

		}

		public override double CalcularSalario()
		{
			return ValorSalario = 5000;
		}
	}
}
