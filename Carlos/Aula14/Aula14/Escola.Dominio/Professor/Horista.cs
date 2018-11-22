using System;

namespace Escola.Dominio
{
    public class Horista : Professor
    {
		public double Hora { get; set; }

		public Horista(double hora)
		{
			Hora = hora;
		}

		public override double CalcularSalario()
		{
			return Hora * 17;
		}
	}
}
