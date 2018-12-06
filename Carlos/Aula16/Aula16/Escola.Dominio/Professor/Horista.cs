using System;

namespace Escola.Dominio
{
    public class Horista : Professor
    {
		public double HoraTrabalhada { get; set; }
        public double ValorSalarioHoraTrabalhada { get; set; }

        public Horista(int codigo, string nome, double horaTrabalhada, double valorSalarioHoraTrabalhada)
			: base (codigo, nome)
		{
			Codigo = codigo;
			Nome = nome;
			HoraTrabalhada = horaTrabalhada;
            ValorSalarioHoraTrabalhada = valorSalarioHoraTrabalhada;
        }

		public override double CalcularSalario()
		{
			return HoraTrabalhada * 17;
		}
	}
}
