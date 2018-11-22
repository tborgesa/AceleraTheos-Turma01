using System;

namespace Escola.Dominio
{ 
    public abstract class Contratado : Professor
    {
		public double ValorSalario { get; set; }

		public Contratado(double valorSalario)
		{
			ValorSalario = valorSalario;
		}
	}
}
