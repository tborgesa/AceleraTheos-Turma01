using System;

namespace Escola.Dominio
{
    public class Horista : Professor
    {
		public double Hora { get; set; }

		public Horista(double hora, int codigo, string nome)
			: base (codigo, nome)
		{
			Codigo = codigo;
			Nome = nome;
			Hora = hora;
		}

		public override double CalcularSalario()
		{
			return Hora * 17;
		}
	}
}
